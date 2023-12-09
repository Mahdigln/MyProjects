﻿using StrategyPattern.Interface;
using StrategyPattern.Model;

namespace StrategyPattern.Repository;

class IranKishStrategy : IPSP
{
    public bool AddAcceptor(POS pos)
    {
        Console.WriteLine("Add : " + pos.ToString());
        return true;
    }

    public bool EditAcceptor(POS pos)
    {
        Console.WriteLine("Edit : " + pos.ToString());
        return true;
    }

    public bool Inquery(int trackId)
    {
        Console.WriteLine("Inquery IranKish : " + trackId);
        return true;
    }
}