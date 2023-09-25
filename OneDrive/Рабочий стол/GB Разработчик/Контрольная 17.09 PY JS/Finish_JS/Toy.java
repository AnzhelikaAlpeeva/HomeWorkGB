import java.util.Objects;

public class Toy implements Comparable<Toy> {
    private int toyID;
    private String toyName;
    private int toyPeriod;
    
    public Toy(int toyID, String toyName, int toyPeriod) {
        this.toyID = toyID;
        this.toyName = toyName;
        this.toyPeriod = toyPeriod;        
    }

    public int getToyID() {
        return toyID;
    }

    public String getToyName() {
        return toyName;
    }

    public int getToyPeriod() {
        return toyPeriod;
    }
    
    public void setToyPeriod(int toyPeriod) {
        this.toyPeriod = toyPeriod;
    }
    
    public String getInfo() {
        return String.format("id: %d, Name: %s", toyID, toyName);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Toy toy = (Toy) o;
        return toyName.equals(toy.toyName);
    }

    @Override
    public int hashCode() {
        return Objects.hash(toyName);
    }

    @Override
    public int compareTo(Toy o) {
        return Integer.compare(this.toyPeriod, o.toyPeriod);
    }
}