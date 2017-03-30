# Plata.Port
Parallel port wrapper for C#

# How to use

- You must include the inpout.dll (or inpout32.dll depending on your machine) in the Debug folder
- Reference the compiled library to your project

# Coding
## Creating an instance</br>

```csharp
ParallelPort pport = new ParallelPort();
pport.Connect(port_address_in_decimal);
```
or
```csharp
using (pport.Connect(port_address_in_decimal))
{
  /* Some code here... */
}
```

## Send data to the Parallel Port
### Method 1
Create an instance of DataPort

```csharp
DataPort dataPort = new DataPort();
dataPort.Reset(); // Set all pins to zero (low)
dataPort.pin0 = 1;// Set pin0 to 1 (high)
dataPort.pin2 = 1;// Set pin2 to 1 (high)
```
or
```csharp
dataPort.pins = 00000101; // Set pin0 and pin2 to 1 (high) and the rest is zero (low) 
```

then send it to the port

```csharp
pport.Send(dataPort);
```


### Method 2

Send an int to the port
```csharp
pport.Send(5);
```
