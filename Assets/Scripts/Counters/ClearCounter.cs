using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

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

}
