package leetcode.tests;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.params.provider.Arguments.arguments;

import java.util.LinkedHashMap;
import java.util.List;
import java.util.SequencedMap;
import java.util.function.Predicate;
import java.util.stream.Stream;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

class P1207UniqueNumberOfOccurrencesTest {

    private static final SequencedMap<String, Predicate<int[]>> VERSIONS = new LinkedHashMap<>();

    static {
        VERSIONS.put("V3", arr -> new leetcode.p1207.v3.Solution().uniqueOccurrences(arr));
        VERSIONS.put("V2026", arr -> new leetcode.p1207.v2026.Solution().uniqueOccurrences(arr));
    }

    private static final List<Arguments> CASES = List.of(
            arguments(new int[] {1, 2, 2, 1, 1, 3}, true),
            arguments(new int[] {1, 2}, false),
            arguments(new int[] {-3, 0, 1, -3, 1, 1, 1, -3, 10, 0}, true),
            arguments(new int[] {7}, true),
            arguments(new int[] {5, 5, 5}, true),
            arguments(new int[] {1, 1, 2, 2}, false),
            arguments(new int[] {-1000, 1000, 1000}, true),
            arguments(new int[] {3, 1, 2, 2, 3, 3}, true),
            arguments(new int[] {1, 2, 3}, false));

    static Stream<Arguments> data() {
        return VersionMatrix.of(VERSIONS.keySet(), CASES);
    }

    @ParameterizedTest(name = "{0}: {1} -> {2}")
    @MethodSource("data")
    void uniqueOccurrences_returnsWhetherAllCountsAreDistinct(String version, int[] arr, boolean expected) {
        assertEquals(expected, VERSIONS.get(version).test(arr));
    }
}
