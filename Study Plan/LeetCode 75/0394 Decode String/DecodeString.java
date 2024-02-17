/*  
    Problem
    --------------------------------------------------------------------------------
    394. Decode String
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Runtime 1 ms (Beats 77.47% of users with Java)
    - Memory 41.12 MB (Beats 89.97% of users with Java)
*/

public class Solution {
    public String decodeString(String s) {
        String encoded = s;
        StringBuilder decoded = new StringBuilder();
        Stack<String> letters = new Stack<>();
        Stack<Integer> numbers = new Stack<>();
        int k = 0;
        for (char character : encoded.toCharArray()) {
            if (Character.isDigit(character)) {
                k = k * 10 + (character - '0');
            } else if (character == '[') {
                letters.push(decoded.toString());
                numbers.push(k);
                decoded = new StringBuilder();
                k = 0;
            } else if (character == ']') {
                String letter = letters.pop();
                int number = numbers.pop();
                StringBuilder data = new StringBuilder();
                for (int index = 0; index < number; index++) {
                    data.append(decoded);
                }
                decoded = new StringBuilder(letter).append(data);
            } else {
                decoded.append(character);
            }
        }
        return decoded.toString();
    }
}
