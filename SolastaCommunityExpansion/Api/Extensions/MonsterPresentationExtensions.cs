using System;
using System.CodeDom.Compiler;
using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.Extensions;

/// <summary>
///     This helper extensions class was automatically generated.
///     If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
/// </summary>
[TargetType(typeof(MonsterPresentation))]
[GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
public static class MonsterPresentationExtensions
{
    public static MonsterPresentation Copy(this MonsterPresentation entity)
    {
        return new MonsterPresentation(entity);
    }

    public static T SetAttachedParticlesReference<T>(this T entity,
        AssetReference value)
        where T : MonsterPresentation
    {
        entity.SetField("attachedParticlesReference", value);
        return entity;
    }

    public static T SetBestiaryAttachedParticlesReference<T>(this T entity,
        AssetReference value)
        where T : MonsterPresentation
    {
        entity.SetField("bestiaryAttachedParticlesReference", value);
        return entity;
    }

    public static T SetCanGeneratePortrait<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("canGeneratePortrait", value);
        return entity;
    }

    public static T SetCustomMaterials<T>(this T entity, AssetReference[] value)
        where T : MonsterPresentation
    {
        entity.SetField("customMaterials", value);
        return entity;
    }

    public static T SetCustomShaderReference<T>(this T entity, AssetReference value)
        where T : MonsterPresentation
    {
        entity.SetField("customShaderReference", value);
        return entity;
    }

    public static T SetFemaleModelScale<T>(this T entity, Single value)
        where T : MonsterPresentation
    {
        entity.SetField("femaleModelScale", value);
        return entity;
    }

    public static T SetFemalePrefabReference<T>(this T entity, AssetReference value)
        where T : MonsterPresentation
    {
        entity.SetField("femalePrefabReference", value);
        return entity;
    }

    public static T SetFirstCharacterShaderColor<T>(this T entity, Color value)
        where T : MonsterPresentation
    {
        entity.SetField("firstCharacterShaderColor", value);
        return entity;
    }

    public static T SetHasLightingCutscene<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hasLightingCutscene", value);
        return entity;
    }

    public static T SetHasMonsterPortraitBackground<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hasMonsterPortraitBackground", value);
        return entity;
    }

    public static T SetHasPhantomDistortion<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hasPhantomDistortion", value);
        return entity;
    }

    public static T SetHasPrefabVariants<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hasPrefabVariants", value);
        return entity;
    }

    public static T SetHasUniqueName<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hasUniqueName", value);
        return entity;
    }

    public static T SetHideDuringCutscene<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hideDuringCutscene", value);
        return entity;
    }

    public static T SetHideWieldedItemsWhenPassive<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("hideWieldedItemsWhenPassive", value);
        return entity;
    }

    public static T SetHumanoidMonsterPresentationDefinitions<T>(this T entity,
        HumanoidMonsterPresentationDefinition[] value)
        where T : MonsterPresentation
    {
        entity.SetField("humanoidMonsterPresentationDefinitions", value);
        return entity;
    }

    public static T SetMaleModelScale<T>(this T entity, Single value)
        where T : MonsterPresentation
    {
        entity.SetField("maleModelScale", value);
        return entity;
    }

    public static T SetMalePrefabReference<T>(this T entity, AssetReference value)
        where T : MonsterPresentation
    {
        entity.SetField("malePrefabReference", value);
        return entity;
    }

    public static T SetMonsterPresentationDefinitions<T>(this T entity, MonsterPresentationDefinition[] value)
        where T : MonsterPresentation
    {
        entity.SetField("monsterPresentationDefinitions", value);
        return entity;
    }

    public static T SetMutantFleshDirection<T>(this T entity, Vector3 value)
        where T : MonsterPresentation
    {
        entity.SetField("mutantFleshDirection", value);
        return entity;
    }

    public static T SetNeedMerchantPortrait<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("needMerchantPortrait", value);
        return entity;
    }

    public static T SetOverrideCharacterShaderColors<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("overrideCharacterShaderColors", value);
        return entity;
    }

    public static T SetPortraitCameraFollowOffset<T>(this T entity, Vector3 value)
        where T : MonsterPresentation
    {
        entity.SetField("portraitCameraFollowOffset", value);
        return entity;
    }

    public static T SetPortraitCameraFOV<T>(this T entity, Single value)
        where T : MonsterPresentation
    {
        entity.SetField("portraitCameraFOV", value);
        return entity;
    }

    public static T SetPortraitCameraLightingOffset<T>(this T entity, Vector3 value)
        where T : MonsterPresentation
    {
        entity.SetField("portraitCameraLightingOffset", value);
        return entity;
    }

    public static T SetPortraitCameraLookAtScreenOffset<T>(this T entity, Vector2 value)
        where T : MonsterPresentation
    {
        entity.SetField("portraitCameraLookAtScreenOffset", value);
        return entity;
    }

    public static T SetSecondCharacterShaderColor<T>(this T entity, Color value)
        where T : MonsterPresentation
    {
        entity.SetField("secondCharacterShaderColor", value);
        return entity;
    }

    public static T SetUniqueNameTitle<T>(this T entity, String value)
        where T : MonsterPresentation
    {
        entity.SetField("uniqueNameTitle", value);
        return entity;
    }

    public static T SetUseCustomMaterials<T>(this T entity, Boolean value)
        where T : MonsterPresentation
    {
        entity.SetField("useCustomMaterials", value);
        return entity;
    }

    public static T SetWieldedItemsScale<T>(this T entity, Single value)
        where T : MonsterPresentation
    {
        entity.SetField("wieldedItemsScale", value);
        return entity;
    }
}
