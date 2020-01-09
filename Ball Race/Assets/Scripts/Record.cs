[System.Serializable]
public class Record 
{
    public double record1 { get; set; }
    public double record2 { get; set; }
    public double record3 { get; set; }

    public Record(double r1, double r2, double r3)
    {
        this.record1 = r1;
        this.record2 = r2;
        this.record3 = r3;
    }
}

