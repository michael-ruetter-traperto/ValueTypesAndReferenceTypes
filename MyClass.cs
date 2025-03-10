namespace ValueAndReferenceTypes;

public class MyClass
{
    public int Value { get; set; }
    public string Name { get; set; }
    
    public MyClass(int value, string name)
    {
        Value = value;
        Name = name;
    }
}

public struct MyStruct
{
    public int Value { get; set; }
    public string Name { get; set; }
    
    public MyStruct(int value, string name)
    {
        Value = value;
        Name = name;
    }
}

public class ClassLikeStruct
{
    public int Value { get; init; }
    public string Name { get; init; }
    
    public ClassLikeStruct(int value, string name)
    {
        Value = value;
        Name = name;
    }

    public override bool Equals(object obj)
    {
        if(obj is ClassLikeStruct other)
        {
            return Value == other.Value && Name == other.Name;
        }
        
        return false;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Name);
    }
    
    public static bool operator ==(ClassLikeStruct left, ClassLikeStruct right)
    {
        return left.Equals(right);
    }
    
    public static bool operator !=(ClassLikeStruct left, ClassLikeStruct right)
    {
        return !left.Equals(right);
    }
}

public record MyRecord(int Value, string Name);

public class RecordClass
{
    public int Value { get; init; }
    public string Name { get; init; }
}