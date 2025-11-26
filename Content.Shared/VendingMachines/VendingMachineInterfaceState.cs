// SPDX-FileCopyrightText: 2022 Andreas Kämper <andreas@kaemper.tech>
// SPDX-FileCopyrightText: 2024 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Serialization;

namespace Content.Shared.VendingMachines
{
    [Serializable, NetSerializable]
    public sealed class VendingMachineEjectMessage : BoundUserInterfaceMessage
    {
        public readonly InventoryType Type;
        public readonly string ID;
        //Pirate banking start
        public double PriceMultiplier;
        public int Credits;
        public VendingMachineEjectMessage(InventoryType type, string id, double priceMultiplier,
            int credits)
        //Pirate banking end
        {
            Type = type;
            ID = id;
            //Pirate banking start
            PriceMultiplier = priceMultiplier;
            Credits = credits;
            //Pirate banking end
        }
    }

    //Pirate banking start
    [Serializable, NetSerializable]
    public sealed class VendingMachineWithdrawMessage : BoundUserInterfaceMessage
    {
    }
    //Pirate banking end

    [Serializable, NetSerializable]
    public enum VendingMachineUiKey
    {
        Key,
    }
}