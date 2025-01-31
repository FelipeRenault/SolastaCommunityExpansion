﻿using System;
using SolastaModApi.Extensions;

namespace SolastaCommunityExpansion.Builders.Features;

public class
    FeatureDefinitionPowerBuilder : FeatureDefinitionPowerBuilder<FeatureDefinitionPower,
        FeatureDefinitionPowerBuilder>
{
    #region Constructors

    protected FeatureDefinitionPowerBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
    {
    }

    protected FeatureDefinitionPowerBuilder(string name, string definitionGuid) : base(name, definitionGuid)
    {
    }

    protected FeatureDefinitionPowerBuilder(FeatureDefinitionPower original, string name, Guid namespaceGuid) :
        base(original, name, namespaceGuid)
    {
    }

    protected FeatureDefinitionPowerBuilder(FeatureDefinitionPower original, string name, string definitionGuid) :
        base(original, name, definitionGuid)
    {
    }

    #endregion
}

public abstract class
    FeatureDefinitionPowerBuilder<TDefinition, TBuilder> : FeatureDefinitionBuilder<TDefinition, TBuilder>
    where TDefinition : FeatureDefinitionPower
    where TBuilder : FeatureDefinitionPowerBuilder<TDefinition, TBuilder>
{
    protected override void Initialise()
    {
        base.Initialise();

        if (Definition.EffectDescription == null)
        {
            // The game throws an exception if there is no effect description.
            Definition.SetEffectDescription(new EffectDescription());
        }
    }

    public TBuilder Configure(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
        string usesAbilityScoreName, RuleDefinitions.ActivationTime activationTime, int costPerUse,
        RuleDefinitions.RechargeRate recharge,
        bool proficiencyBonusToAttack, bool abilityScoreBonusToAttack, string abilityScore,
        EffectDescription effectDescription)
    {
        Definition.SetFixedUsesPerRecharge(usesPerRecharge);
        Definition.SetUsesDetermination(usesDetermination);
        Definition.SetUsesAbilityScoreName(usesAbilityScoreName);
        Definition.SetActivationTime(activationTime);
        Definition.SetCostPerUse(costPerUse);
        Definition.SetRechargeRate(recharge);
        Definition.SetProficiencyBonusToAttack(proficiencyBonusToAttack);
        Definition.SetAbilityScoreBonusToAttack(abilityScoreBonusToAttack);
        Definition.SetAbilityScore(abilityScore);
        Definition.SetEffectDescription(effectDescription);

        return This();
    }

    public TBuilder Configure(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
        string usesAbilityScoreName, RuleDefinitions.ActivationTime activationTime, int costPerUse,
        RuleDefinitions.RechargeRate recharge,
        bool proficiencyBonusToAttack, bool abilityScoreBonusToAttack, string abilityScore,
        EffectDescription effectDescription, FeatureDefinitionPower overridenPower)
    {
        Configure(usesPerRecharge, usesDetermination, usesAbilityScoreName, activationTime, costPerUse,
            recharge, proficiencyBonusToAttack, abilityScoreBonusToAttack, abilityScore, effectDescription);

        Definition.SetOverriddenPower(overridenPower);

        return This();
    }

    public TBuilder Configure(int usesPerRecharge, RuleDefinitions.UsesDetermination usesDetermination,
        string usesAbilityScoreName, RuleDefinitions.ActivationTime activationTime, int costPerUse,
        RuleDefinitions.RechargeRate recharge,
        bool proficiencyBonusToAttack, bool abilityScoreBonusToAttack, string abilityScore,
        EffectDescription effectDescription, bool uniqueInstance)
    {
        Configure(usesPerRecharge, usesDetermination, usesAbilityScoreName, activationTime, costPerUse,
            recharge, proficiencyBonusToAttack, abilityScoreBonusToAttack, abilityScore, effectDescription);

        Definition.SetUniqueInstance(uniqueInstance);

        return This();
    }

    public TBuilder SetEffectDescription(EffectDescription effect)
    {
        Definition.SetEffectDescription(effect);
        return This();
    }

    public TBuilder DelegatedToAction()
    {
        Definition.SetDelegatedToAction(true);
        return This();
    }

    public TBuilder SurrogateToSpell(SpellDefinition spell)
    {
        Definition.SetSurrogateToSpell(spell);
        return This();
    }

    public TBuilder SetActivation(RuleDefinitions.ActivationTime time, int costPerUse)
    {
        Definition.SetActivationTime(time);
        Definition.SetCostPerUse(costPerUse);
        return This();
    }

    // TODO: combine with above with default?
    public TBuilder SetActivationTime(RuleDefinitions.ActivationTime value)
    {
        Definition.SetActivationTime(value);
        return This();
    }

    public TBuilder SetReaction(RuleDefinitions.ReactionTriggerContext context, string name)
    {
        Definition.SetReactionContext(context);
        Definition.SetReactionName(name);
        return This();
    }

    public TBuilder SetCastingFailure(RuleDefinitions.CastingSuccessComputation computation)
    {
        Definition.SetHasCastingFailure(true);
        Definition.SetCastingSuccessComputation(computation);
        return This();
    }

    public TBuilder CanUseInDialog()
    {
        Definition.SetCanUseInDialog(true);
        return This();
    }

    public TBuilder SetDisablingCondition(ConditionDefinition condition)
    {
        Definition.SetDisableIfConditionIsOwned(condition);
        return This();
    }

    public TBuilder SetRechargeRate(RuleDefinitions.RechargeRate rate)
    {
        Definition.SetRechargeRate(rate);

        return This();
    }

    public TBuilder SetShortTitleOverride(string titleOverride)
    {
        Definition.SetShortTitleOverride(titleOverride);
        return This();
    }

    public TBuilder SetSpellCastingFeature(FeatureDefinitionCastSpell spellFeature)
    {
        Definition.SetSpellcastingFeature(spellFeature);
        return This();
    }

    public TBuilder SetUsesFixed(int fixedUses)
    {
        Definition.SetFixedUsesPerRecharge(fixedUses);
        Definition.SetUsesDetermination(RuleDefinitions.UsesDetermination.Fixed);
        return This();
    }

    public TBuilder SetFixedUsesPerRecharge(int fixedUses)
    {
        Definition.SetFixedUsesPerRecharge(fixedUses);
        return This();
    }

    public TBuilder SetCostPerUse(int costPerUse)
    {
        Definition.SetCostPerUse(costPerUse);
        return This();
    }

    public TBuilder SetUsesProficiency()
    {
        Definition.SetUsesDetermination(RuleDefinitions.UsesDetermination.ProficiencyBonus);
        return This();
    }

    public TBuilder SetAbilityScore(string abilityScoreName)
    {
        Definition.SetAbilityScore(abilityScoreName);
        return This();
    }

    public TBuilder SetUsesAbilityScoreName(string abilityScoreName)
    {
        Definition.SetUsesAbilityScoreName(abilityScoreName);
        return This();
    }

    public TBuilder SetUsesAbility(int fixedUses, string attribute)
    {
        Definition.SetFixedUsesPerRecharge(fixedUses);
        Definition.SetUsesAbilityScoreName(attribute);
        Definition.SetUsesDetermination(RuleDefinitions.UsesDetermination.AbilityBonusPlusFixed);
        return This();
    }

    public TBuilder UseSpellCastingModifier()
    {
        Definition.SetAbilityScoreDetermination(RuleDefinitions.AbilityScoreDetermination.SpellcastingAbility);
        return This();
    }

    public TBuilder SetAttackModifierAbility(bool ability, bool proficiency, string attribute)
    {
        Definition.SetAbilityScore(attribute);
        Definition.SetAbilityScoreBonusToAttack(ability);
        Definition.SetProficiencyBonusToAttack(proficiency);
        Definition.SetAttackHitComputation(RuleDefinitions.PowerAttackHitComputation.AbilityScore);
        return This();
    }

    public TBuilder SetAttackModifierStatic(int attackModifier)
    {
        Definition.SetFixedAttackHit(attackModifier);
        Definition.SetAttackHitComputation(RuleDefinitions.PowerAttackHitComputation.Fixed);
        return This();
    }

    public TBuilder SetUniqueInstance(bool uniqueInstance)
    {
        Definition.SetUniqueInstance(uniqueInstance);
        return This();
    }

    public TBuilder SetShowCasting(bool casting)
    {
        Definition.SetShowCasting(casting);
        return This();
    }

    public TBuilder SetOverriddenPower(FeatureDefinitionPower overridenPower)
    {
        Definition.SetOverriddenPower(overridenPower);
        return This();
    }

    public TBuilder SetShortTitle(string title)
    {
        Definition.SetShortTitleOverride(title);
        return This();
    }

    public TBuilder SetAbility(string ability)
    {
        Definition.SetAbilityScore(ability);
        return This();
    }

    #region Constructors

    protected FeatureDefinitionPowerBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
    {
    }

    protected FeatureDefinitionPowerBuilder(string name, string definitionGuid) : base(name, definitionGuid)
    {
    }

    protected FeatureDefinitionPowerBuilder(TDefinition original, string name, Guid namespaceGuid) : base(original,
        name, namespaceGuid)
    {
    }

    protected FeatureDefinitionPowerBuilder(TDefinition original, string name, string definitionGuid) : base(
        original, name, definitionGuid)
    {
    }

    #endregion
}
