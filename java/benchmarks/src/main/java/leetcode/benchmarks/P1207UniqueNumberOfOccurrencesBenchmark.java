package leetcode.benchmarks;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;
import java.util.concurrent.TimeUnit;
import org.openjdk.jmh.annotations.Benchmark;
import org.openjdk.jmh.annotations.BenchmarkMode;
import org.openjdk.jmh.annotations.Fork;
import org.openjdk.jmh.annotations.Measurement;
import org.openjdk.jmh.annotations.Mode;
import org.openjdk.jmh.annotations.OutputTimeUnit;
import org.openjdk.jmh.annotations.Param;
import org.openjdk.jmh.annotations.Scope;
import org.openjdk.jmh.annotations.Setup;
import org.openjdk.jmh.annotations.State;
import org.openjdk.jmh.annotations.Warmup;

/**
 * {@code ALL_UNIQUE} is the worst case: the answer is true, so every version must
 * count every value. {@code RANDOM} repeats counts early, so versions that stop at
 * the first repeated count can return before building the whole set.
 */
@State(Scope.Benchmark)
@BenchmarkMode(Mode.AverageTime)
@OutputTimeUnit(TimeUnit.MICROSECONDS)
@Warmup(iterations = 3, time = 1)
@Measurement(iterations = 5, time = 1)
@Fork(1)
public class P1207UniqueNumberOfOccurrencesBenchmark {

    public enum Scenario { ALL_UNIQUE, RANDOM }

    @Param({"1000", "100000"})
    int length;

    @Param({"ALL_UNIQUE", "RANDOM"})
    Scenario input;

    int[] arr;

    @Setup
    public void setup() {
        var random = new Random(1207);
        arr = switch (input) {
            case ALL_UNIQUE -> allUnique(length, random);
            case RANDOM -> random.ints(length, -1000, 1001).toArray();
        };
    }

    @Benchmark
    public boolean v3() {
        return new leetcode.p1207.v3.Solution().uniqueOccurrences(arr);
    }

    @Benchmark
    public boolean v2026() {
        return new leetcode.p1207.v2026.Solution().uniqueOccurrences(arr);
    }

    // Value k appears k times (1, 2, 2, 3, 3, 3, ...), shuffled.
    private static int[] allUnique(int length, Random random) {
        var values = new ArrayList<Integer>(length);
        for (var value = 1; values.size() + value <= length; value++) {
            values.addAll(Collections.nCopies(value, value));
        }
        Collections.shuffle(values, random);
        return values.stream().mapToInt(Integer::intValue).toArray();
    }
}
