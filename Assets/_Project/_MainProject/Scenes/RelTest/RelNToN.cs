public class RelNToN : _RelNToN
{
    public float maxDistance;
    private void LateUpdate()
    {
        GetRelToInfo();

        SetRelPos();
    }

    private void GetRelToInfo()
    {
        this.transform.position = VectorExt.GetMeanOf(RelTo);

        this.maxDistance = VectorExt.GetMaxDistance(RelTo);
    }

    public virtual void SetRelPos()
    {
        foreach (var obj in this.Rel)
        {
            obj.transform.position = this.transform.position;
        }
    }


}
