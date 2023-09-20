import java.util.*;

public class mainNote {
    public static void main(String[] args) {
        Notebook acerNote = new Notebook(256, "gray", "Windows");
        Notebook samsungNote = new Notebook(256, "white", "Windows");
        Notebook lgNote = new Notebook(128, "black", "Windows");
        Notebook honorNote = new Notebook(512, "gray", "Windows");
        Notebook macAirNote = new Notebook(256, "gray", "MacOS");
        Notebook macProNote = new Notebook(1024, "gray", "MacOS");
        Notebook macProNote512 = new Notebook(512, "gray", "MacOS");
        ArrayList<Notebook> notebooks = new ArrayList<>(
            Arrays.asList(acerNote, samsungNote, lgNote, honorNote, macAirNote, macProNote, macProNote512));
        System.out.println(
            "Здравствуйте! Введите параметры для подбора ноутбука (объем ЖД, цвет, ОС): ");
        Map<String, Integer> mapOptions = new HashMap<>();
        mapOptions.put("hardDiskV", 0);
        mapOptions.put("colour", 0);
        mapOptions.put("osNote", 0);
        
        Notebook.printForUser(mapOptions);
        Scanner scnNote = new Scanner(System.in);

        int numOption = -1;
        Set<Integer> setNumOptions = new HashSet<>();

        while (numOption != 0) {
            if (setNumOptions.size() == 0) {
                numOption = scnNote.nextInt();
                
                setNumOptions.add(numOption);
            }

            if (numOption == 1) {
                System.out.println(
                    "Введите минимальный объем ЖД: ");
                int minHardDiskV = scnNote.nextInt();
                mapOptions.put("hardDiskV", minHardDiskV);
                Notebook.printForUser(mapOptions);
                numOption = scnNote.nextInt();
                if (!Notebook.checkNumOption(numOption, setNumOptions)) {
                    break;
                }
                setNumOptions.add(numOption);
            }

            if (numOption == 2) {
                System.out.println(
                    "Для выбора цвета:\n нажмите цифру 1 для серого(gray),\n нажмите цифру 2 для черного(black),\n нажмите цифру 3 для белого(white): ");
                int numColour = scnNote.nextInt();
                mapOptions.put("colour", numColour);
                
                Notebook.printForUser(mapOptions);
                numOption = scnNote.nextInt();
                if (!Notebook.checkNumOption(numOption, setNumOptions)) {
                    break;
                }                
                setNumOptions.add(numOption);
            }

            if (numOption == 3) {
                System.out.println("Для выбора ОС:\n введите 1, чтобы выбрать Windows\n введите 2, чтобы выбрать MacOS: ");
                int numOSNote = scnNote.nextInt();
                mapOptions.put("osNote", numOSNote);
                
                if (setNumOptions.size() == 3) {
                    break;
                }
                Notebook.printForUser(mapOptions);
                numOption = scnNote.nextInt();
                if (!Notebook.checkNumOption(numOption, setNumOptions)) {
                    break;
                }         
            }
        }

        ArrayList<Notebook> setResult = Notebook.getSetOptions(notebooks, mapOptions);
        if (setResult.size() == 0) {
            System.out.println("Ноутбука по выбранным критериям нет, попробуйте изменить параметры:)");
        } else {
            System.out.println("Выбранные вами критерии есть у ноутбука: ");
            System.out.println(setResult);
        }
        scnNote.close();
    }
}
