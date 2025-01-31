using System;
using System.CodeDom.Compiler;
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions;

/// <summary>
///     This helper extensions class was automatically generated.
///     If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
/// </summary>
[TargetType(typeof(EffectAdvancement))]
[GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
public static class EffectAdvancementExtensions
{
    public static EffectAdvancement Copy(this EffectAdvancement entity)
    {
        var copy = new EffectAdvancement();
        copy.Copy(entity);
        return copy;
    }

    public static T SetAdditionalDicePerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalDicePerIncrement", value);
        return entity;
    }

    public static T SetAdditionalHPPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalHPPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalItemBonus<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalItemBonus", value);
        return entity;
    }

    public static T SetAdditionalSpellLevelPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalSpellLevelPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalSubtargetsPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalSubtargetsPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalSummonsPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalSummonsPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalTargetCellsPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalTargetCellsPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalTargetsPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalTargetsPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalTempHPPerIncrement<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalTempHPPerIncrement", value);
        return entity;
    }

    public static T SetAdditionalWeaponDie<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("additionalWeaponDie", value);
        return entity;
    }

    public static T SetAlteredDuration<T>(this T entity, AdvancementDuration value)
        where T : EffectAdvancement
    {
        entity.SetField("alteredDuration", value);
        return entity;
    }

    public static T SetEffectIncrementMethod<T>(this T entity, EffectIncrementMethod value)
        where T : EffectAdvancement
    {
        entity.SetField("effectIncrementMethod", value);
        return entity;
    }

    public static T SetIncrementMultiplier<T>(this T entity, Int32 value)
        where T : EffectAdvancement
    {
        entity.SetField("incrementMultiplier", value);
        return entity;
    }
}
