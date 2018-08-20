import java.util.Scanner;

public class Cellulitis {
    /**
     * Cellular automaton: consists of a grid of cells containing a symbol form a finite set of symbols.
     * Generation:         content of the whole grid -- changes in step according to the rules described below.
     *
     *  I.      Only the current generation is used to compute the next one
     *  II.     Each cell adheres to the same rules
     *  III.    {definition of Grid:}  a single row of cells
     *  IV.     A cell's new value is only based on it's neighbours (dictated as the neighbourhood): one cel, lift or
     *          right, for cells at the ends of a grid -- two, right and left, for the rest of the cells.
     *  V       The only value a cell can have is occupied or empty
     *
     * Below we define, our automaton:
     *
     *  A:
     *     If cell if occupied:
     *          remains occupied only if one of it's neighbours is occupied. It dies if it has two neighbours or none.
     *     If a cell is empty:
     *          it only remains empty if it's neighbourhood is daedere.
     *
     *  B:
     *      If cell is occupied:
     *          if the cell is currently occupied, it remains occupied only if the right neighbour is empty
     *      If a cell is empty:
     *          the cell is currently empty, it becomes occupied if exactly one neighbour is occupied.
     *
     *  U:
     *      the universal automaton. Determined by the rule sequence we know which of the 256 (2^8, because we have
     *      8 numbers which can be 0 or 1) rulesets the automaton has to adhere to.
     *
     *      So this automaton sets all cells to true of pattern n of cell k is in our rule sequence.
     */

    boolean[] currentGeneration;
    boolean[] nextGeneration;
    // Boolean Array which will hold our ruleSequence
    boolean[] ruleSequence;
    // variable which hold the length of our grid
    int gridLen;
    // amount of generations to be computed and drawn
    int numGenerations;
    // type of universal automaton to be executed
    String automatonType;
    // Scanner object to get user input
    Scanner sc = new Scanner(System.in);


    public void readGeneral() {
        // reads the general input (up to the initial configuration)
        //set automatonType to be the next token from the scanner.
        automatonType = sc.next();
        // do the same with gridLen only then set it to be the next integer that is found.
        gridLen = sc.nextInt();
        // repeat previous step.
        numGenerations = sc.nextInt();

    }


    public void readInitial() {
        // reads the initial configuration (build the first currentGeneration)
        // Creating boolean array and adding two columns to simplify calculations.
        currentGeneration = new boolean[gridLen + 2];

        // read "init_start"
        sc.next();

        // Keeps looping through our scanner object while it has ints.
        // If it finds an int that is within our gridLan domain set the value of this int to True in our first current
        // generation.
        while (sc.hasNextInt()) {
            int value = sc.nextInt();
            if (value > 0 && value <= gridLen) {
                currentGeneration[value] = true;
            }
        }
        // reads the end of our initialization input: "init_end"
        sc.next();
    }


    public void readRules() {
        // reads the ruleset (only implement in case of an universal automaton)
        // fill up boolean array ruleSequence ( which we first create); we convert user input to 1 to TRUE and 0 to FALSE.
        ruleSequence = new boolean[8];
        for (int i = 0; i < 8; i++) {
            int rule = sc.nextInt();
            ruleSequence[i] = rule == 1;
        }

    }


    boolean newCellValueByA(int k) {
        // return the value {true, false} of cell number k
        // for the next generation according to the rules of A
        if (currentGeneration[k]) {
            if (!currentGeneration[k - 1] && !currentGeneration[k + 1]) {
               return false;
            } else if(currentGeneration[k - 1] && currentGeneration[k + 1]) {
                return false;
            } else {
                return true;
            }
        } else {
            if (currentGeneration[k - 1] || currentGeneration[k + 1]) {
                return true;
            } else {
                return false;
            }

        }
    }


    boolean newCellValueByB(int k) {
        // return the value {true, false} of cell number k
        // for the next generation according to the rules of B
        if (currentGeneration[k]) {
            if (!currentGeneration[k + 1]) {
                return true;
            } else {
                return false;
            }
        } else {
            if (currentGeneration[k - 1] ^ currentGeneration [k + 1]) {
                return true;
            } else {
                return false;
            }
        }
    }


    boolean newCellValueByRules(int k){
        // returns the value {true, false} of cell number k
        // for the next generation according to the universal automatons rules

        /**
         * Because the neighbourhoods value in binary (from 0 to 7) corresponds to  which pattern (numbered from
         * 0 to 7 as well) we mean to switch on or off at input (i.e. 0 1 1 0 1 1 0 1 ) we can simply look in our
         * ruleSequence and check if the pattern that k has is switched on or off.
         *
         */
        return ruleSequence[getPattern(k)];
    }


    public void draw() {
        // draws the current state of the automaton; in other words: print currentGeneration
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 1; i < currentGeneration.length - 1; i++) {
            if (currentGeneration[i]) {
                stringBuilder.append("*");
            } else {
                stringBuilder.append(" ");
            }
        }
        System.out.println(stringBuilder.toString());
    }


    public void computeNextGeneration() {
        // computes the nextGeneration and update the currentGeneration.
        // we create a new empty nextGen array as big as currentGen
        nextGeneration = new boolean[gridLen + 2];
        // checks which automaton should be executed; loops through currentGen, computes nextGen and replaces currentGen
        // with nextGen.
        for (int i = 1; i < currentGeneration.length - 1; i++) {
            switch (automatonType) {
                case "A":
                    nextGeneration[i] = newCellValueByA(i);
                    break;
                case "B":
                    nextGeneration[i] = newCellValueByB(i);
                    break;
                case "U":
                    nextGeneration[i] = newCellValueByRules(i);
                    break;
            }
        }
        currentGeneration = nextGeneration;
        nextGeneration = new boolean[gridLen + 2];
    }


    public void run() {
        // implements the procedure for the assignment:
        // Read the general input and then the initial current state. If the automaton type is the universal automaton
        // then we'll also read the rule sequence.
        readGeneral();
        readInitial();
        if (automatonType.equals("U")) {
            readRules();
        }
        for (int i = 0; i < numGenerations; i++) {
            draw();
            computeNextGeneration();
        }
    }

    // This method checks what pattern cell k has and returns the binary code of this pattern which we'll use to look up
    // if this pattern is "turned on" in our ruleSequence.
    int getPattern(int k) {
        // set bits to 1 on if cell is true and 0 if it's false.
        int bit1 = (currentGeneration[k - 1]) ? 1 : 0;
        int bit2 = (currentGeneration[k]) ? 1 : 0;
        int bit3 = (currentGeneration[k + 1]) ? 1 : 0;
        return bit1 * 4 + bit2 * 2 + bit3;
    }


    public static void main(String[] args) {

        (new Cellulitis()).run();
    }
}
