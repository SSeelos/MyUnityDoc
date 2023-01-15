using UnityEngine;

public class OnTimerSpawner : _PrefabSpawner<Transform>
{
    [SerializeField]
    float rate;
    float counter;
    public bool spawning;

    private void Update()
    {
    }
    private void FixedUpdate()
    {
        Spawning();
    }

    private void Spawning()
    {
        if (!spawning)
            return;

        counter += Time.deltaTime;

        if (counter >= rate)
        {
            counter = 0;

            Instantiate(prefab);
        }
    }
}
