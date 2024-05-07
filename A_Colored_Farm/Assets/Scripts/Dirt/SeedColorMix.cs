using UnityEngine;

public class SeedColorMix : MonoBehaviour
{
    [SerializeField] private PlaceColor _placeColor;
    [SerializeField] private PlaceSeed _placeSeed;
    [field: SerializeField] public ColorData TheColor;
    [field: SerializeField] public SeedData TheSeed;
    public enum Color
    {
        blue,
        red,

    }
    public Color sydeColor;

    int[,] ColorSomething;

    private void FixedUpdate()
    {

        ColorSomething[0, 1] = 5;

        if (_placeColor.IsPainting == true && _placeSeed.IsPlanting == true)
        {
            switch (TheColor.ColorID)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }

        }
    }
}
