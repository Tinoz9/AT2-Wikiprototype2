using System;
using System.Collections;

public class Information : IComparable<Information> //,IComparer<Information>
{
    private String Name;
    private String Category;
    private String Structure;
    private String Definition;


    public Information(string name, string category, string structure, string definition)
    {
        Name = name;
        Category = category;
        Structure = structure;
        Definition = definition;
    }

    public Information(string name)
    {
        this.Name = name;
        this.Category = "";
        this.Structure = "";
        this.Definition = "";
    }

    public int CompareTo(Information other)
    {
        if (other != null)
        {
            return this.Name.CompareTo(other.Name);
        } else
        {
            
        }
        throw new NotImplementedException();
    }



    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public string category
    {
        get { return Category; }
        set { Category = value; }
    }

    public string structure
    {
        get { return Structure; }
        set { Structure = value; }
    }

    public string definition
    {
        get { return Definition; }
        set
        {
            Definition = value;
        }
    }
}