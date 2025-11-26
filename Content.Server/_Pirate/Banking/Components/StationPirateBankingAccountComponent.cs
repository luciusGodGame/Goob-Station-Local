using Content.Shared._Pirate.Banking;
using Robust.Shared.GameObjects;

namespace Content.Server._Pirate.Banking.Components; 

[RegisterComponent]
public sealed partial class StationPirateBankingAccountComponent : Component
{
    [DataField]
    public BankAccount? BankAccount;
}