
public class StringV2_04 {
    public static void main(String[] args) {
        String songLyrics = "You say goodbye, and I say hello.";

        // Using contains() equivalent in Java.
        boolean result = songLyrics.contains("goodbye");
        System.out.println(String.format("%b", result));
        System.out.println(String.format("%b", songLyrics.contains("greetings")));

        // Using startsWith()
        boolean begin1 = songLyrics.startsWith("You");
        System.out.println(String.format("\"%s\" starts with \"%s\" : %b", songLyrics, "You", begin1));
        
        boolean begin2 = songLyrics.startsWith("hello");
        System.out.println(String.format("\"%s\" starts with \"%s\" : %b", songLyrics, "hello", begin2));

        // Using endsWith()
        boolean end1 = songLyrics.endsWith("hello.");
        System.out.println(String.format("\"%s\" ends with \"%s\" : %b", songLyrics, "hello.", end1));
        
        boolean end2 = songLyrics.endsWith("say");
        System.out.println(String.format("\"%s\" ends with \"%s\" : %b", songLyrics, "say", end2));
    }
}
