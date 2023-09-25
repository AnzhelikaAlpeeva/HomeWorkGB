import java.util.Scanner;

public class mainToySh {
    public static void main(String[] args) {
        ToyShop tShop = new ToyShop();
        Scanner sCan = new Scanner(System.in);
        while (true) {
            System.out.println("Меню: \n 0 - Выйти \n 1 - Добавить новую игрушку в список призов \n 2 - Изменить частоту выпадения \n 3 - Разыграть игрушку и записать результат");
            var selection = sCan.next();
            switch(selection) {
                case "1" -> tShop.addToys();
                case "2" -> tShop.setPeriod();
                case "3" -> tShop.toyShop();
                case "0" -> {
                    System.out.println("Пока:)");
                    System.exit(0);
                }
            }
        }
    }
}