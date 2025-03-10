using ValueAndReferenceTypes;

#pragma warning disable CS0219 // Variable is assigned but its value is never used

var valueType = "Tobias, Max";

Console.WriteLine(valueType); 
// Tobias, Max
AddToValueType(valueType);
Console.WriteLine(valueType); 
// Tobias, Max

static void AddToValueType(string value)
{
    value += ", Dominic";
}

Console.WriteLine("-----------------------------------------");

var referenceType = new List<string>()
{
    "Tobias", "Max"
};

Console.WriteLine(string.Join(", ", referenceType)); 
// Tobias, Max
AddToReferenceType(referenceType);
Console.WriteLine(string.Join(", ", referenceType)); 
// Tobias, Max, Dominic

static void AddToReferenceType(List<string> list)
{
    list.Add("Dominic");
}

Console.WriteLine("-----------------------------------------");


Console.WriteLine(valueType); 
// Tobias, Max
AddToValueTypeWithRef(ref valueType);
Console.WriteLine(valueType); 
// Tobias, Max, Dominic

static void AddToValueTypeWithRef(ref string value)
{
    value += ", Dominic";
}


Console.WriteLine("-----------------------------------------");


var myClass = new MyClass(1, "class");
//var myClassWithoutParameters = new MyClass(); Compile error
var myStruct = new MyStruct(1, "struct");
var myStructWithoutParameters = new MyStruct();

//Console.WriteLine("-----------------------------------------");

var myClass1 = new MyClass(1, "class");
var myClass2 = new MyClass(1, "class");
Console.WriteLine(myClass1 == myClass2); // False
Console.WriteLine(myClass1.Equals(myClass2)); // False

var myStruct1 = new MyStruct(1, "struct");
var myStruct2 = new MyStruct(1, "struct");
//Console.WriteLine(myStruct1 == myStruct2);
Console.WriteLine(myStruct1.Equals(myStruct2)); // True

Console.WriteLine("-----------------------------------------");

var myClassChangeTest = new MyClass(1, "class");
ChangeValueClass(myClassChangeTest);
Console.WriteLine(myClassChangeTest.Value); // 2

static void ChangeValueClass(MyClass myClass)
{
    myClass.Value = 2;
}

var myStructChangeTest = new MyStruct(1, "struct");
ChangeValueStruct(myStructChangeTest);
Console.WriteLine(myStructChangeTest.Value); // 1

static void ChangeValueStruct(MyStruct myStruct)
{
    myStruct.Value = 2;
}

Console.WriteLine("-----------------------------------------");

var myRecord1 = new MyRecord(1, "record");
var myRecord2 = new MyRecord(1, "record");
Console.WriteLine(myRecord1 == myRecord2); // True
Console.WriteLine(myRecord1.Equals(myRecord2)); // True

var recordClass = new RecordClass()
{
    Value = 1, 
    Name = "record"
};

var myRecord = new MyRecord(1, "record");


Console.WriteLine("-----------------------------------------");

var myRecordChangeTest = new MyRecord(1, "record"); 
var recordModified = myRecordChangeTest with { Value = 2 };
    
Console.WriteLine(recordModified.Value);

Console.WriteLine("-----------------------------------------");

var myRecordChangeTest2 = new MyRecord(1, "record");
var myRecordChangeTest3 = new MyRecord(2, "record");

var changedRecord = myRecordChangeTest3 with { Value = 1 };

Console.WriteLine(changedRecord == myRecordChangeTest2); // True
Console.WriteLine(changedRecord.Equals(myRecordChangeTest2)); // True

Console.WriteLine(myRecordChangeTest2.Value);
Console.WriteLine(myRecordChangeTest3.Value);
Console.WriteLine(changedRecord.Value);


Console.WriteLine("-----------------------------------------");


var myStructMod = new MyStruct(1, "struct");
        
Console.WriteLine("Before ModifyStruct: " + myStructMod.Value); // 1
ModifyStruct(ref myStructMod);
Console.WriteLine("After ModifyStruct: " + myStructMod.Value); // 2

static void ModifyStruct(ref MyStruct myStruct)
{
    myStruct.Value = 2;
}

Console.WriteLine("-----------------------------------------");


var myClassMod = new MyClass(1, "class");
        
Console.WriteLine("Before ModifyClass: " + myClassMod.Value); // 1
ModifyClass(myClassMod);
Console.WriteLine("After ModifyClass: " + myClassMod.Value); // 2

static void ModifyClass(MyClass myClass)
{
    myClass.Value = 2;
}

Console.WriteLine("-----------------------------------------");

var myClassMod2 = new MyClass(1, "class");
        
Console.WriteLine("Before ModifyClass: " + myClassMod2.Value); // 1
ModifyClassIn(in myClassMod2);
Console.WriteLine("After ModifyClass: " + myClassMod2.Value); // 2

static void ModifyClassIn(in MyClass myClass)
{
    //myClass = new MyClass(2, "class"); Compile error
    myClass.Value = 2;
}

Console.WriteLine("-----------------------------------------");

static void ModifyIntIn(in int value)
{ 
    //value = 2; Compile error
}









return;
