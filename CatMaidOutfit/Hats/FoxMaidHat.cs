using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenCatMaidOutfit.Hats
{
    public class FoxMaidHat : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "foxmaidhat";
        public override CosmeticType CosmeticType => CosmeticType.Hat;
        public override GameObject Visual => Main.bundle.LoadAsset<GameObject>("FoxMaidHat");
        public override bool BlockHats => true;

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Fox Maid Headband").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Fox Maid Headband", new Material[] {
                MaterialUtils.GetExistingMaterial("Carrot"),
                MaterialUtils.GetExistingMaterial("Clothing White")
            });
        }
    }
}