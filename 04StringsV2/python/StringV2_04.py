def main():
    songLyrics = "You say goodbye, and I say hello."

    # Using the "in" operator for .Contains() equivalent
    result = "goodbye" in songLyrics
    print(f"{result}")
    print(f"{'greetings' in songLyrics}")

    # Using startswith()
    begin1 = songLyrics.startswith("You")
    print(f"\"{songLyrics}\" starts with \"You\" : {begin1}")

    begin2 = songLyrics.startswith("hello")
    print(f"\"{songLyrics}\" starts with \"hello\" : {begin2}")

    # Using endswith()
    end1 = songLyrics.endswith("hello.")
    print(f"\"{songLyrics}\" ends with \"hello.\" : {end1}")

    end2 = songLyrics.endswith("say")
    print(f"\"{songLyrics}\" ends with \"say\" : {end2}")

if __name__ == "__main__":
    main()
