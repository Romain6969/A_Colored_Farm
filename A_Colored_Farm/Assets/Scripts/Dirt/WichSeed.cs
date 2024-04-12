using UnityEngine;

public class WichSeed : MonoBehaviour
{
    [field: SerializeField] public bool _redSeed { get; set; }
    [field: SerializeField] public bool _blueSeed { get; set; }
    [field: SerializeField] public bool _yellowSeed { get; set; }
    [field: SerializeField] public bool _greySeed { get; set; }
    [field: SerializeField] public bool _greenSeed { get; set; }
    [field: SerializeField] public bool _orangeSeed { get; set; }
    [field: SerializeField] public bool _purpleSeed { get; set; }

    private void Start()
    {
        _redSeed = false;
        _blueSeed = false;
        _yellowSeed = false;
        _greySeed = false;
        _greenSeed = false;
        _orangeSeed = false;
        _purpleSeed = false;
    }

    public void PlantRed()
    {
        _redSeed = true;
        _blueSeed = false;
        _yellowSeed = false;
        _greySeed = false;
        _greenSeed = false;
        _orangeSeed = false;
        _purpleSeed = false;
    }

    public void PlantBlue()
    {
        _redSeed = false;
        _blueSeed = true;
        _yellowSeed = false;
        _greySeed = false;
        _greenSeed = false;
        _orangeSeed = false;
        _purpleSeed = false;
    }

    public void PlantYellow()
    {
        _redSeed = false;
        _blueSeed = false;
        _yellowSeed = true;
        _greySeed = false;
        _greenSeed = false;
        _orangeSeed = false;
        _purpleSeed = false;
    }

    public void PlantGrey()
    {
        _redSeed = false;
        _blueSeed = false;
        _yellowSeed = false;
        _greySeed = true;
        _greenSeed = false;
        _orangeSeed = false;
        _purpleSeed = false;
    }

    public void PlantGreen()
    {
        _redSeed = false;
        _blueSeed = false;
        _yellowSeed = false;
        _greySeed = false;
        _greenSeed = true;
        _orangeSeed = false;
        _purpleSeed = false;
    }

    public void PlantOrange()
    {
        _redSeed = false;
        _blueSeed = false;
        _yellowSeed = false;
        _greySeed = false;
        _greenSeed = false;
        _orangeSeed = true;
        _purpleSeed = false;
    }

    public void PlantPurple()
    {
        _redSeed = false;
        _blueSeed = false;
        _yellowSeed = false;
        _greySeed = false;
        _greenSeed = false;
        _orangeSeed = false;
        _purpleSeed = true;
    }
}
