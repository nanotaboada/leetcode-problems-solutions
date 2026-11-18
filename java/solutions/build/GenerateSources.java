/**
 * Copies the original LeetCode solutions into a generated source root.
 *
 * <p>Each file gets a package derived from its problem folder and file name,
 * plus the imports LeetCode provides implicitly:
 *
 * <pre>
 * 1207 .../UniqueNumberOfOccurrencesV3.java    -> leetcode.p1207.v3
 * 1207 .../UniqueNumberOfOccurrences.2026.java -> leetcode.p1207.v2026
 * </pre>
 *
 * <p>The prefix is written on the original first line, so line numbers in
 * compiler errors and stack traces match the original file. The top-level class
 * is made public so tests and benchmarks in other packages can use it.
 *
 * <p>Usage: {@code java GenerateSources.java <study-plan-dir> <output-dir>}
 */
static final Pattern PROBLEM_NUMBER = Pattern.compile("^\\d+");
static final Pattern YEAR = Pattern.compile("\\.(\\d{4})$");
static final Pattern VERSION = Pattern.compile("V(\\d+)$");
static final Pattern TOP_LEVEL_CLASS = Pattern.compile("(?m)^(?:public\\s+)?class\\s+(\\w+)");
static final String IMPORTS = "import java.util.*; import java.util.function.*; import java.util.stream.*;";

void main(String[] args) throws IOException {
    var sourceRoot = Path.of(args[0]);
    var outputRoot = Path.of(args[1]);

    List<Path> sources;
    try (var files = Files.walk(sourceRoot)) {
        sources = files.filter(path -> path.toString().endsWith(".java")).sorted().toList();
    }

    var packages = new HashSet<String>();
    for (var source : sources) {
        var packageName = packageOf(source);
        if (!packages.add(packageName)) {
            throw new IllegalStateException("Duplicate package %s for %s".formatted(packageName, source));
        }

        var content = Files.readString(source);
        var topLevelClass = TOP_LEVEL_CLASS.matcher(content);
        if (!topLevelClass.find()) {
            throw new IllegalStateException("No top-level class in " + source);
        }

        var target = outputRoot
                .resolve(packageName.replace('.', '/'))
                .resolve(topLevelClass.group(1) + ".java");
        var generated = "package %s; %s ".formatted(packageName, IMPORTS)
                + TOP_LEVEL_CLASS.matcher(content).replaceFirst("public class $1");

        Files.createDirectories(target.getParent());
        if (!Files.exists(target) || !Files.readString(target).equals(generated)) {
            Files.writeString(target, generated);
        }
    }
}

static String packageOf(Path source) {
    var folder = source.getParent().getFileName().toString();
    var name = source.getFileName().toString().replaceFirst("\\.java$", "");

    var number = PROBLEM_NUMBER.matcher(folder);
    if (!number.find()) {
        throw new IllegalStateException("Cannot infer problem number from folder " + folder);
    }

    var year = YEAR.matcher(name);
    var version = VERSION.matcher(name);
    var suffix = year.find() ? year.group(1) : version.find() ? version.group(1) : "1";

    return "leetcode.p%04d.v%s".formatted(Integer.parseInt(number.group()), suffix);
}
