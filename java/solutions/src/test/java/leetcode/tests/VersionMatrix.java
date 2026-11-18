package leetcode.tests;

import java.util.Collection;
import java.util.List;
import java.util.stream.Stream;
import org.junit.jupiter.params.provider.Arguments;

/** Builds arguments that run every test case against every version of a solution. */
final class VersionMatrix {

    private VersionMatrix() {}

    static Stream<Arguments> of(Collection<String> versions, List<Arguments> cases) {
        return versions.stream().flatMap(version -> cases.stream().map(testCase -> {
            var values = testCase.get();
            var withVersion = new Object[values.length + 1];
            withVersion[0] = version;
            System.arraycopy(values, 0, withVersion, 1, values.length);
            return Arguments.of(withVersion);
        }));
    }
}
