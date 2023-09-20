import java.util.ArrayList;
import java.util.Map;
import java.util.Set;

public class Notebook {
    private int hardDiskV;
    private String colour;
    private String osNote;

    public void setHardDiskV(int hardDiskV) {
        this.hardDiskV = hardDiskV;
    }

    public void setColour(String colour) {
        this.colour = colour;
    }

    public void setOSNote(String osNote) {
        this.osNote = osNote;
    }

    public int getHardDiskV() {
        return hardDiskV;
    }

    public String getColour() {
        return colour;
    }

    public String getOSNote() {
        return osNote;
    }

    @Override
    public String toString() {
        return String.format("hardDiskV = %d, colour = %s, osNote = %s \n", hardDiskV, colour, osNote);
    }

    public Notebook(int hardDiskV, String colour, String osNote) {
        this.hardDiskV = hardDiskV;
        this.colour = colour;
        this.osNote = osNote;
    }

    public static int getIndexColour(String colour) {
        if (colour.equals("gray")) {
            return 1;
        }
        if (colour.equals("black")) {
            return 2;
        }
        if (colour.equals("white")) {
            return 3;
        }
        return 0;
    }

    public static int getIndexOSNote(String osNote) {
        if (osNote.equals("Windows")) {
            return 1;
        }
        if (osNote.equals("MacOS")) {
            return 2;
        }
        return 0;
    }
    
    public static boolean checkNumOption(int numOption, Set<Integer> setNumOptions) {
        if (numOption == 0) {
            return false;
        }
        if (numOption < 0 && numOption > 3) {
            System.out.println("Вы ввели некорректный номер критерия выбора");
            return false;
        }
        if (setNumOptions.contains(numOption)) {
            System.out.println("Такой номер критерия уже выбран");
            return false;
        }
        return true;
    }

    public static void printForUser(Map<String, Integer> mapOptions) {
        int indexHardDiskV = mapOptions.get("hardDiskV");
        int indexColour = mapOptions.get("colour");
        int indexOSNote = mapOptions.get("osNote");
        StringBuilder srtOption = new StringBuilder();
        if (indexHardDiskV == 0 || indexColour == 0 && indexOSNote == 0) {
            srtOption.append("Введите цифру, соответствующую необходимому критерию:\n");
        }
        if (indexHardDiskV == 0) {
            srtOption.append(" 1 - Объем жесткого диска\n");
        }
        if (indexColour == 0) {
            srtOption.append(" 2 - Цвет ноутбука\n");
        }
        if (indexOSNote == 0) {
            srtOption.append(" 3 - Операционная система\n");
        }
        System.out.println(srtOption.append(" 0 - для завершения выбора\n").toString());
    }

    public static ArrayList<Notebook> getSetOptions(ArrayList<Notebook> setNotebooks, Map<String, Integer> mapOptions) {
        int indexColour = mapOptions.get("colour");
        int indexOSNote = mapOptions.get("osNote");
        int minHardDiskV = 0;
        if (mapOptions.containsKey("hardDiskV")) {
            minHardDiskV = mapOptions.get("hardDiskV");
        }
        ArrayList<Notebook> setResult = new ArrayList<>();
        for (int i = 0; i < setNotebooks.size(); i++) {
            if (setNotebooks.get(i).hardDiskV >= minHardDiskV) {
                if (indexColour == 0 && indexOSNote == 0) {
                    setResult.add(setNotebooks.get(i));
                } else if (indexColour == 0 
                        && getIndexOSNote(setNotebooks.get(i).osNote) == mapOptions.get("osNote")) {
                    setResult.add(setNotebooks.get(i));
                } else if (indexOSNote == 0 
                        && getIndexColour(setNotebooks.get(i).colour) == mapOptions.get("colour")) {
                    setResult.add(setNotebooks.get(i));
                } else if (getIndexColour(setNotebooks.get(i).colour) == mapOptions.get("colour")
                        && getIndexOSNote(setNotebooks.get(i).osNote) == mapOptions.get("osNote")) {
                    setResult.add(setNotebooks.get(i));
                }
            }
        }
        return setResult;
    }
}