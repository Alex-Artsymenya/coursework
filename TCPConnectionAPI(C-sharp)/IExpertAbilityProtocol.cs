﻿using DatabaseEntities;

namespace TCPConnectionAPI_C_sharp_
{
    public interface IExpertAbilityProtocol : IClientAbilityProtocol
    {
        bool Rate(DetailNomenclature entity, Expert expert, float rate);
    }
}