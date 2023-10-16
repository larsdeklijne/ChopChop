using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;

    public override void Interact(Player player) {
        // only pickup and drop items
        if (!HasKitchenObject()) {

            // there is no kitchenObject
            if (player.HasKitchenObject()) {
                // player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {
                // Player has carrying anything
            }

        } else {
            // there is a kitchenObject
            if (player.HasKitchenObject()) {
                // player is carrying something
            } else {
                // Player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player) {
        if (HasKitchenObject()) {
            // there is a kitchenObject here
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}

