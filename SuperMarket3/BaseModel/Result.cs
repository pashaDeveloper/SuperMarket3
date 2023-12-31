﻿namespace SuperMarket.BaseModel;

public class Result<T>
{
    public T Data { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}