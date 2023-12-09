using StrategyPattern.Context;
using StrategyPattern.Interface;
using StrategyPattern.Model;
using StrategyPattern.Repository;
using System;

namespace StrategyPattern.Service;

class PSPService : IPSP
{
    private PSPContext context;
    private PSPEnum psp;
    public PSPService(PSPEnum psp)
    {
        this.psp = psp;
    }
    public bool AddAcceptor(POS pos)
    {
        switch (psp)
        {
            case PSPEnum.IranKish:
                context = new PSPContext(new IranKishStrategy());
                break;
            case PSPEnum.Parsian:
                context = new PSPContext(new ParsianStrategy());
                break;
            default:
                context = null;
                break;
        }
        if (context == null)
            return false;
        return context.AddAcceptor(pos);
    }

    public bool EditAcceptor(POS pos)
    {
        switch (psp)
        {
            case PSPEnum.IranKish:
                context = new PSPContext(new IranKishStrategy());
                break;
            case PSPEnum.Parsian:
                context = new PSPContext(new ParsianStrategy());
                break;
            default:
                context = null;
                break;
        }
        if (context == null)
            return false;
        return context.EditAcceptor(pos);
    }

    public bool Inquery(int trackId)
    {
        switch (psp)
        {
            case PSPEnum.IranKish:
                context = new PSPContext(new IranKishStrategy());
                break;
            case PSPEnum.Parsian:
                context = new PSPContext(new ParsianStrategy());
                break;
            default:
                context = null;
                break;
        }
        if (context == null)
            return false;
        return context.Inquery(trackId);
    }
}