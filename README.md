#Plata.Port
Parallel port wrapper for C#

#How to use
<ul>
<li>You must include the inpout.dll (or inpout32.dll depending on your machine) in the Debug folder</li>
<li>Reference the compiled library to your project</li>
</ul>

#Coding
##Creating an instance</br>
<code>ParallelPort pport = new ParallelPort();</code></br>
<code>pport.Connect(port_address_in_decimal);</code>
</br>or</br>
<code>
using (pport.Connect(port_address_in_decimal))
{
  /* Some code here... */
}
</code>

##Send data to the Parallel Port
###Method 1
Create an instance of DataPort
</br>
<code>DataPort dataPort = new DataPort();</code></br>
<code>dataPort.Reset(); // Set all pins to zero (low)</code></br>
<code>dataPort.pin0 = 1;// Set pin0 to 1 (high)</code></br>
<code>dataPort.pin2 = 1;// Set pin2 to 1 (high)</code>
</br>or</br>
<code>
dataPort.pins = 00000101; // Set pin0 and pin2 to 1 (high) and the rest is zero (low) 
</code></br></br>
then send it to the port</br>
<code>
pport.Send(dataPort);
</code>
</br>
</br>
###Method 2
</br>
Send an int to the port</br>
<code>
pport.Send(5);
</code>
