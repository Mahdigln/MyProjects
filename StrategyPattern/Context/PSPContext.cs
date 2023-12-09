using StrategyPattern.Interface;
using StrategyPattern.Model;

namespace StrategyPattern.Context;

class PSPContext : IPSP
{
    private IPSP psp;
    public PSPContext(IPSP psp)
    {
        this.psp = psp;
    }
    public bool AddAcceptor(POS pos)
    {
        return psp.AddAcceptor(pos);
    }

    public bool EditAcceptor(POS pos)
    {
        return psp.EditAcceptor(pos);
    }

    public bool Inquery(int trackId)
    {
        return psp.Inquery(trackId);
    }
}