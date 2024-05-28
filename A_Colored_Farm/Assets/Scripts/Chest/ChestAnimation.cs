using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    [SerializeField] private ChestInventory _chestInventory;
    [SerializeField] private List<Animator> _animatorList;
    [SerializeField] private List<int> _verifList;

    void Start()
    {
        _verifList[0] = _chestInventory.GraySeed;
        _verifList[1] = _chestInventory.BlueSeed;
        _verifList[2] = _chestInventory.YellowSeed;
        _verifList[3] = _chestInventory.RedSeed;

        for (var i = 0; i < _animatorList.Count; i++)
        {
            _animatorList[i].enabled = false;
        }
    }

    void Update()
    {
        if (_verifList[0] != _chestInventory.GraySeed)
        {
            _animatorList[0].enabled = true;
            StartCoroutine(Wait0());
            _verifList[0] = _chestInventory.GraySeed;
        }

        if (_verifList[1] != _chestInventory.BlueSeed)
        {
            _animatorList[1].enabled = true;
            StartCoroutine(Wait1());
            _verifList[1] = _chestInventory.BlueSeed;
        }

        if (_verifList[2] != _chestInventory.YellowSeed)
        {
            _animatorList[2].enabled = true;
            StartCoroutine(Wait2());
            _verifList[2] = _chestInventory.YellowSeed;
        }

        if (_verifList[3] != _chestInventory.RedSeed)
        {
            _animatorList[3].enabled = true;
            StartCoroutine(Wait3());
            _verifList[3] = _chestInventory.RedSeed;
        }
    }

    IEnumerator Wait0()
    {
        yield return new WaitForSeconds(0.28f);
        _animatorList[0].enabled = false;
    }

    IEnumerator Wait1()
    {
        yield return new WaitForSeconds(0.28f);
        _animatorList[1].enabled = false;
    }

    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(0.28f);
        _animatorList[2].enabled = false;
    }

    IEnumerator Wait3()
    {
        yield return new WaitForSeconds(0.28f);
        _animatorList[3].enabled = false;
    }
}
