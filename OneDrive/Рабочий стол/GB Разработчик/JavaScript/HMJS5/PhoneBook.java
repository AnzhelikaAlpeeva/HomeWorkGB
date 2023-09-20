// Реализуйте структуру телефонной книги с помощью HashMap.
// Программа также должна учитывать, что во входной структуре будут повторяющиеся имена 
// с разными телефонами, их необходимо считать, как одного человека с разными телефонами. 
// Вывод должен быть отсортирован по убыванию числа телефонов.

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class PhoneBook{
    
    public static void addNumber(String key, Integer value, Map<String, ArrayList<Integer>> map){ // метод, который добавляет номера 
        if (map.containsKey(key)) {
            map.get(key).add(value);
        } else {
            ArrayList<Integer> list = new ArrayList<>();
            list.add(value);
            map.put(key, list);
        }
    }
    
    public static void printDirectory(Map<String, ArrayList<Integer>> map){  // метод, который печатает список
        for (var item : map.entrySet()) {
            String phone = "";
            for(int elem: item.getValue()){
                phone = phone + elem + "/ ";
            }
            System.out.printf("%s: %s \n", item.getKey(), phone);
        }
    }
    public static void main(String[] args) {
        Map<String, ArrayList<Integer>> phoneDirectory = new HashMap<>();
        addNumber("Иванов", 2647436, phoneDirectory);
        addNumber("Иванов", 2739038, phoneDirectory);
        addNumber("Сидоров", 2549783, phoneDirectory);
        addNumber("Сидоров", 2952349, phoneDirectory);
        addNumber("Петров", 2352255, phoneDirectory);
        addNumber("Петров", 2780098, phoneDirectory);
        addNumber("Иванов", 2230191, phoneDirectory);
        printDirectory(phoneDirectory);
    }
    
}
