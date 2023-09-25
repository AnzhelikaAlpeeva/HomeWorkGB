import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.*;

public class ToyShop {
    private static ArrayList<Toy> toys = new ArrayList<>();
    private static PriorityQueue<Toy> gifts = new PriorityQueue<>();

    private static int idCount = 0;

    private static boolean isDigit(String s) throws NumberFormatException {
        try {
            Integer.parseInt(s);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    public void setPeriod() {
        Scanner scr = new Scanner(System.in);
        System.out.print("Введите ID игрушки: ");
        String value = scr.nextLine();
        if (isDigit(value)) {
            int selectID = Integer.parseInt(value);
            if(selectID >= 0 && selectID < toys.size()) {
                System.out.println("Игрушка " + toys.get(selectID).getToyName() + "имеет частоту побед" + 
                toys.get(selectID).getToyPeriod());
                System.out.print("Введите новую частоту выпадения: ");
                value = scr.nextLine();
                if(isDigit(value)) {
                    int newPeriod = Integer.parseInt(value);
                    toys.get(selectID).setToyPeriod(newPeriod);
                    System.out.println("Частота была изменена");
                } else {
                    System.out.println("Некорректный ввод, попробуйте еще раз");
                }                
            } else {
                System.out.println("Игрушки по данному ID не найдено");
            }
        } else {
            System.out.println("Некорректный ввод, попробуйте еще раз");
        }
    }

    public Toy getGift() {
        if(gifts.size() == 0) {
            Random rand = new Random();
            for(Toy toy : toys) {
                for(int i = 0; i < toy.getToyPeriod(); i++) {
                    Toy temp = new Toy(toy.getToyID(), toy.getToyName(), rand.nextInt(1, 10));
                    gifts.add(temp);
                }
            }
        }
        return gifts.poll();
    }

    public void toyShop() {
        if(toys.size() >= 2) {
            Toy gift = getGift();
            System.out.println("Подарок: " + gift.getToyName());
            saveResult(gift.getInfo());
        } else {
            System.out.println("Необходимо добавить две игрушки");
        }
    }

    private void saveResult(String text) {
        File textFile = new File("Result.txt");
        try {
            textFile.createNewFile();
        } catch (Exception ignor) {
            throw new RuntimeException();
        }
        try (FileWriter fileW = new FileWriter("Result.txt", true)) {
            fileW.write(text + "\n");
        } catch (IOException exce) {
            System.out.println(exce.getMessage());
        }
    }

    public void addToys() {
        Scanner scr = new Scanner(System.in);
        String name;
        int period;
        while (true) {
            System.out.print("Введите название игрушки: ");
            name = scr.nextLine();
            if(name.isEmpty()) {
                System.out.println("Некорректный ввод, попробуйте снова");
                break;
            }
            System.out.print("Введите частоту выбрасывания: ");
            String value = scr.nextLine();
            if(isDigit(value)) {
                period = Integer.parseInt(value);
                if(period <= 0) {
                    System.out.println("Некорректный ввод, попробуйте снова");
                } else {
                    Toy toy = new Toy(idCount, name, period);
                    if(!toys.contains(toy) || toys.size() == 0) {
                        idCount++;
                        toys.add(toy);
                        System.out.println("Новая игрушка была добавлена:)");                    
                    } else {
                        System.out.println("Эта игрушка уже есть в списке");
                    }
                }
            } else {
                System.out.println("Некорректный ввод, попробуйте снова");
            }
            break;
        }
    }
}    