import java.util.Scanner;

/**
 * Created by bram_ on 9-9-2017.
 */
public class Rectangle {
    public static void main(String[] args) {
        new Rectangle().run();
    }

    void run() {
        Scanner scanner = new Scanner(System.in);
        int xTopLeft = scanner.nextInt();
        int yTopLeft = scanner.nextInt();
        int xBottomRight = scanner.nextInt();
        int yBottomRight = scanner.nextInt();
        int x = scanner.nextInt();
        int y = scanner.nextInt();

        if((xTopLeft < xBottomRight ) && (yTopLeft > yBottomRight)) {
            if ((x <= xBottomRight && x >= xTopLeft) && (y <= yTopLeft && y >= yBottomRight)) {
                System.out.println("inside");
            } else {
                System.out.println("outside");
            }
        } else {
            System.out.println("error");
        }
    }
}