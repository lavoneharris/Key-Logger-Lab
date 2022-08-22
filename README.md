<h1>KeyLogger Project</h1>



<h2>Description</h2>
This KeyLogger Project consists of a C# script that will record the input of user on any application running on the device. This will also create a .txt for the attacker with the recorded keystroke inputs in a Programdata Folder. Note if you have a good AntiVirus (such as Bitdefender Antivirus) this program will not run as it will block and delete the path to write thekeylogger.exe file.That took some troubleshooting and use of StackOverFlow as my Antivirus did not warm be of the blocking of the .exe. You will need to both unquarantine and create a exclsuion for the path in the Antivirus. Keyloggers are considered a Spyware because it spys on your information without you noticing. 
<br />



<h2>Keyloggers Are Considered Dangerous For Several Reasons:</h2>
- Allows the attacker to see patterns, for instance say you use a the same Username/Email and Password for both for Facebook and Amazon Account. Once they recognize this pattern they may have access to both these accounts and could maybe do a Social Engineer Attack posing as you on Facebook or Purchase items on your Amazon Account.<br>
- Say you are a politican searching up personal information on google such as (How to Get Away With Murder or How to cheat on your Spouse) if an attacker gets ahold of these keystrokes they could try and blackmail for this information to remain private.<br>
- Identity Theft.<br>
- Physical/Virtual Stalking.<br>

<h2>How Keyloggers Can Be Distrubuted:</h2>
- MP3 music files<br>
- E-mail attachments<br>
- Clicking on deceptive pop–ups<br>
- P2P networks<br>
- AVI files (i.e., "YouTube" or other videos)<br>
- A legitimate Web site link, picture, or story that was malfaced<br>
- Downloaded games or any other PC tools or programs<br>
- Faked malicious Web sites that impersonate popular sites (sites such as Google, eBay, Amazon, Yahoo, banks) or anti-virus programs<br>

<h2>How To Protect Yourself:</h2>
- Good Up to Date Antivirus.<br>
- Dont Download Unknown Files<br>
- Teaching employees about malware and keyloggers may prevent identity theft or data breach, but is not the grand solution. <br>
- Virtual Keyboard<br>
- Password Manager<br>
- 2 Factor Authentication <br>
<br>
<h2>Languages and Utilities Used</h2>

- C# 
- Visual Studio Community Edition 2022

<h2>Environments Used </h2>

- Windows 10

<h2>Program walk-through:</h2>

<p align="center">
Error Message in Debug: <br/>
<img src="https://i.imgur.com/CEsUbLw" height="80%" width="80%" alt="Disk Sanitization Steps"/>
<br />
<br />
Reason for Error in Debug (Antivirus Deleted Writing the keylogger.exe):  <br/>
<img src="https://i.imgur.com/tcTyMUE.png" height="80%" width="80%" alt="Disk Sanitization Steps"/>
<br />
<br />
Adding Exclusion & Unquarantining: <br/>
<img src="https://i.imgur.com/nCIbXbg.png" height="80%" width="80%" alt="Disk Sanitization Steps"/>
<br />
<br />
Keylogger Logging Inputing keystrokes from Notepad:  <br/>
<img src="https://i.imgur.com/cdFHBiU.png" height="80%" width="80%" alt="Disk Sanitization Steps"/>
<br />
<br />
Keylogger as it writes to a .txt in ProgramData:  <br/>
<img src="https://i.imgur.com/JL945Ga.png" height="80%" width="80%" alt="Disk Sanitization Steps"/>
<br />
<br />
Sanitization complete:  <br/>
<img src="https://i.imgur.com/K71yaM2.png" height="80%" width="80%" alt="Disk Sanitization Steps"/>
<br />
<br />
Observe the wiped disk:  <br/>
<img src="https://i.imgur.com/AeZkvFQ.png" height="80%" width="80%" alt="Disk Sanitization Steps"/>
</p>

<!--
 ```diff
- text in red
+ text in green
! text in orange
# text in gray
@@ text in purple (and bold)@@
```

