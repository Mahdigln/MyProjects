using StrategyPattern.Model;

namespace StrategyPattern.Interface;

public interface IPSP
{
    bool AddAcceptor(POS pos);
    bool EditAcceptor(POS pos);
    bool Inquery(int trackId);
}