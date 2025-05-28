import java.util.Scanner;

public class Strings03 {

    // Mimics the C# ToTitle method: capitalizes the first letter and any letter that follows a space.
    public static String toTitle(String s) {
        String result = "";
        for (int i = 0; i < s.length(); i++) {
            if (i == 0 || s.charAt(i - 1) == ' ') {
                result += Character.toUpperCase(s.charAt(i));
            } else {
                result += s.charAt(i);
            }
        }
        return result;
    }

    public static void main(String[] args) {
        // Create a Scanner for any interactive input
        Scanner scanner = new Scanner(System.in);

        String firstName = "Archibald";
        String surname = "Holmes";

        System.out.println(String.format("My full name is %s %s", firstName, surname));
        System.out.println(String.format("%s is of length %d", firstName, firstName.length()));
        System.out.println(String.format("%s is of length %d", surname, surname.length()));

        // Additional string handling with left and right whitespace
        String whiteSpace = "       Lots of leading and trailing white space         ";
        System.out.println(String.format("%s", whiteSpace));

        // Trimming the white space:
        // Using regex to simulate left and right trim operations since Java's trim() handles both.
        String leftTrim = whiteSpace.replaceAll("^\\s+", "");
        String trimmed  = whiteSpace.trim();
        String rightTrim = whiteSpace.replaceAll("\\s+$", "");

        System.out.println(String.format("left trim  = %s", leftTrim));
        System.out.println(String.format(" trimmed   = %s", trimmed));
        System.out.println(String.format("right trim = %s", rightTrim));

        // Substitution, similar to the C# Replace method.
        String fullName = String.format("%s %s", firstName, surname);
        System.out.println(String.format("full name: %s", fullName));

        fullName = fullName.replace("Archibald", "Kate");
        System.out.println(String.format("full name: %s", fullName));

        // Changing cases:
        System.out.println(String.format("full name to upper: %s", fullName.toUpperCase()));

        fullName = fullName.toLowerCase();
        System.out.println(String.format("full name to lower: %s", fullName));

        System.out.println(String.format("Fullname is %s", fullName));
        System.out.println(String.format("fulle name to title: %s", toTitle(fullName)));

        System.out.println(String.format("Fullname is %s", fullName));

        // Using Scanner to read a string from the user for title-case conversion.
        System.out.print(String.format("Enter a string to convert to title-case: "));
        String userInput = scanner.nextLine();
        System.out.println(String.format("Title-case: %s", toTitle(userInput)));

        scanner.close();
    }
}