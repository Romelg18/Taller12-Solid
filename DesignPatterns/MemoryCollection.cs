using System.Collections.Generic;
using DesignPatterns.Models;

namespace DesignPatterns;

public class MemoryCollection
{
    public static MemoryCollection _intance;
    public ICollection<Vehicle> Vehicles { get; set; }

    public MemoryCollection()
    {
        Vehicles = new List<Vehicle>();
    }

    public static MemoryCollection Instance
    {
        get
        {
            if (_intance is not null) return _intance;
            _intance ??= new MemoryCollection();
                return _intance;
        }

    }

}