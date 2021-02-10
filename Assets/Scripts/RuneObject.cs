using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[RequireComponent(typeof(SpriteRenderer))]
public class RuneObject : SerializedMonoBehaviour
{
    public Rune ObjectRune
    {
        get => rune;
        set
        {
            UpdateRune(value);
            rune = value;
        }
    }

    public Rune startingRune;

    public AssetReference fireSprite;
    public AssetReference waterSprite;
    public AssetReference earthSprite;
    public AssetReference airSprite;

    private Dictionary<Rune, AssetReference> runeSprites;
    
    private SpriteRenderer cSpriteRenderer;
    private AsyncOperationHandle<Sprite> currentSpriteOperationHandle;

    private Rune rune;

    private void Awake()
    {
        cSpriteRenderer = GetComponent<SpriteRenderer>();

        runeSprites = new Dictionary<Rune, AssetReference>()
        {
            {Rune.Fire, fireSprite},
            {Rune.Water, waterSprite},
            {Rune.Earth, earthSprite},
            {Rune.Air, airSprite}
        };

        UpdateRune(startingRune);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void UpdateRune(Rune rune)
    {
        if (rune == null || rune == Rune.None)
        {
            cSpriteRenderer.sprite = null;
            return;
        }
        
        StartCoroutine(SetSpriteAsync(rune));
    }

    private IEnumerator SetSpriteAsync(Rune type)
    {
        if (currentSpriteOperationHandle.IsValid())
        {
            Addressables.Release(currentSpriteOperationHandle);
        }

        var spriteReference = runeSprites[type];
        currentSpriteOperationHandle = spriteReference.LoadAssetAsync<Sprite>();

        yield return currentSpriteOperationHandle;

        cSpriteRenderer.sprite = currentSpriteOperationHandle.Result;
    }
}
