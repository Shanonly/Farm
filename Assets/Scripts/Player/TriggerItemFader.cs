using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemFader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        ItemFader[] itemFaders = other.GetComponentsInChildren<ItemFader>();
        foreach (ItemFader itemFader in itemFaders){
            itemFader.FadeOut();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        ItemFader[] itemFaders = other.GetComponentsInChildren<ItemFader>();
        foreach (ItemFader itemFader in itemFaders){
            itemFader.FadeIn();
        }
    }
}
