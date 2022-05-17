public StreamWriter AllocatedStreamWriter()
{
    FileStream fs = File.Create("everwhat.txt");
    return new StreamWriter(fs);
}

public void ResourceLeakBad()
{
    StreamWriter stream = AllocateStreamWriter();
    // FIXME: should close the StreamWriter by calling stream.Close() if stream is not null.
}
