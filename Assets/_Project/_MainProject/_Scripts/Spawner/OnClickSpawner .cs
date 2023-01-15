using UnityEngine;

public class OnClickSpawner : _PrefabSpawner<Transform>
{
    [SerializeField]
    float rate;
    float counter;
    bool spawning;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            spawning = true;
        else
            spawning = false;
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
