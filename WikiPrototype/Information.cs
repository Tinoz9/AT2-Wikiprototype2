using System;
using System.Collections;

public class Information : IComparable<Information>, //IComparer<Information>
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


    public int CompareTo(Information name)
    {
        if (name != null)
        {
            return name.Name.CompareTo(this.Name);
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