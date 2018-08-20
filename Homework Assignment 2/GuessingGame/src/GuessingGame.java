import java.util.*;
// TODO Improve / simplify code.
public class GuessingGame {

    // Create a new Random object.
    Random randomGenerator =  new Random();
    // Create a new Scanner object to get user input.
    Scanner inputScanner = new Scanner(System.in);
    /**
     * @guess:           variable to store user's guess
     * @code:            variable which holds either the "Secret code" typed by the user, or a random number
     * @guessCounter:    variable to keep track of how many guesses a player has made
     * @guessingHistory: an matrix which holds arrays of guess history with the guess and code stored into them
     */
    int guess;
    int code;
    int guessCouter = 0;
    char[][] guessingHistory = new char[7][100];


    /**
     * Initializes the guessingHistory matrix.
     *
     * The first loop loops through every char array, it then fills the array with '.' and then it places an '|' at the
     * code index.
     *
     * TODO one '.' is placed which can already be a '|'.
     */
    void initializeGuessingHistory() {
        for (int i = 0; i < guessingHistory.length; i++) {
            for (int j = 0; j < guessingHistory[i].length; j++) {
                guessingHistory[i][j] = '.';
                guessingHistory[i][code] = '|';
            }
        }
    }


    /**
     * Method used to print the guessingHistory. The first loop loops through every char array up to the amount
     * of guesses the player has made, the second loop prints every element within the array.
     */
    void printGuessingHistory() {
        for (int i = 0; i < guessCouter; i++) {
            for (int j = 0; j < guessingHistory[i].length; j++) {
                System.out.print(guessingHistory[i][j]);
            }
            System.out.println("");
        }
    }


    /**
     * Asks for user input for a maximum of 7 times. Each times the guess (user input) is read and stored at the
     * appropriate index in the guessingHistory. Then it checks if the player has won or not -- a hint is given
     * to tell the player if the guess should be lower or higher.
     */
    void setGuessingHistory() {
        for (int i = 0; i < 7; i++) {
            guessCouter++;
            guess = inputScanner.nextInt();
            guessingHistory[i][guess] = 'X';
            if (guess > code) {
                System.out.println("lower");
            } else if (guess < code) {
                System.out.println("higher");
            } else if (guess == code) {
                System.out.println("Good guess! You won.");
                break;
            }
        }
        System.out.println("No more guesses, you lost.");
    }


    /**
     * Prompts the user of input and decides wether to use the Random integer. Thereafter the guessingHistory is
     * initialized, we prompt the user for guesses and after no more guesses or when the player has won, the
     * guessingHistory is printed.
     */
    void run() {
        System.out.println("Do you want to enter the secret code yourself?");
        String userInput = inputScanner.nextLine();
        if (userInput.equals("yes")) {
            System.out.println("Secretly type the code:");
            code = inputScanner.nextInt();
            System.out.println("Start guessing!");
            initializeGuessingHistory();
            setGuessingHistory();
            printGuessingHistory();

        } else if (userInput.equals("no")) {
            code = randomGenerator.nextInt(100);
            System.out.println("Start guessing!");
            initializeGuessingHistory();
            setGuessingHistory();
            printGuessingHistory();
        }
    }


    public static void main(String[] args) {
        new GuessingGame().run();
    }
}
