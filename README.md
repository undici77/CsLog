# CsLog
A smart and easy to customize thread safe asyncronous logger for your CS project

# What CsLog can do for you
- Can log ERRROS (always)
- Can log INFO (if enabled)
- Can log DEBUG (if enabled)
- Can log CATCH (if enabled)
- Can async log to file
- Can async log to UI 
- Can runtime change log verbose (INFO_LEVEL / DEBUG_LEVEL / CATCH_LEVEL)

# How to integrate in your project
- Copy Log.cs in your project
- Call Log.Instance.Init
- Setup verbose and log to file
- Let's start to log
- Before closing your app call Log.Instance.End

# Unit test output
17:42:03.260595 [INFO] Main: started<br />
17:42:03.270620 [DEBUG] Main: Wait 100 ms and start asynch test thread<br />
17:42:03.371889 [INFO] TestThread: ready to start<br />
17:42:03.374897 [DEBUG] Main: write some debug [0]<br /><br />
17:42:03.398962 [DEBUG] Main: write some debug [1]<br />
17:42:03.400968 [INFO] TestThread: started<br />
17:42:03.400968 [DEBUG] TestThread: write some debug [0]<br />
17:42:03.409991 [DEBUG] Main: write some debug [2]<br />
17:42:03.411996 [DEBUG] TestThread: write some debug [1]<br />
17:42:03.421019 [DEBUG] Main: write some debug [3]<br />
17:42:03.423025 [DEBUG] TestThread: write some debug [2]<br />
17:42:03.432051 [DEBUG] Main: write some debug [4]<br />
17:42:03.434055 [DEBUG] TestThread: write some debug [3]<br />
17:42:03.443081 [DEBUG] Main: write some debug [5]<br />
17:42:03.445086 [DEBUG] TestThread: write some debug [4]<br />
17:42:03.454109 [DEBUG] Main: write some debug [6]<br />
17:42:03.456115 [DEBUG] TestThread: write some debug [5]<br />
17:42:03.465171 [DEBUG] Main: write some debug [7]<br />
17:42:03.468149 [DEBUG] TestThread: write some debug [6]<br />
17:42:03.477170 [DEBUG] Main: write some debug [8]<br />
17:42:03.479174 [DEBUG] TestThread: write some debug [7]<br />
17:42:03.488199 [DEBUG] Main: write some debug [9]<br />
17:42:03.490205 [DEBUG] TestThread: write some debug [8]<br />
17:42:03.499229 [DEBUG] Main: write some debug [10]<br />
17:42:03.501235 [DEBUG] TestThread: write some debug [9]<br />
17:42:03.510257 [DEBUG] Main: write some debug [11]<br />
17:42:03.512263 [DEBUG] TestThread: write some debug [10]<br />
17:42:03.521318 [DEBUG] Main: write some debug [12]<br />
17:42:03.523293 [DEBUG] TestThread: write some debug [11]<br />
17:42:03.532347 [DEBUG] Main: write some debug [13]<br />
17:42:03.534322 [DEBUG] TestThread: write some debug [12]<br />
17:42:03.543345 [DEBUG] Main: write some debug [14]<br />
17:42:03.546354 [DEBUG] TestThread: write some debug [13]<br />
17:42:03.555378 [DEBUG] Main: write some debug [15]<br />
17:42:03.557383 [DEBUG] TestThread: write some debug [14]<br />
17:42:03.566408 [DEBUG] Main: write some debug [16]<br />
17:42:03.568412 [DEBUG] TestThread: write some debug [15]<br />
17:42:03.577436 [DEBUG] Main: write some debug [17]<br />
17:42:03.579442 [DEBUG] TestThread: write some debug [16]<br />
17:42:03.588466 [DEBUG] Main: write some debug [18]<br />
17:42:03.590472 [DEBUG] TestThread: write some debug [17]<br />
17:42:03.599496 [DEBUG] Main: write some debug [19]<br />
17:42:03.602504 [DEBUG] TestThread: write some debug [18]<br />
17:42:03.611564 [INFO] Main: let's try to log a catch exception<br />
17:42:03.611564 [INFO] Main: creating a null string and trying to access to it<br />
17:42:03.613533 [DEBUG] TestThread: write some debug [19]<br />
17:42:03.624562 [DEBUG] TestThread: write some debug [20]<br />
17:42:03.636595 [DEBUG] TestThread: write some debug [21]<br />
17:42:03.642610 [CATCH] Main: Object reference not set to an instance of an object. (Program.cs line:60 Void Main(System.String[]))<br />
17:42:03.647626 [DEBUG] TestThread: write some debug [22]<br />
17:42:03.659708 [DEBUG] TestThread: write some debug [23]<br />
17:42:03.670688 [DEBUG] TestThread: write some debug [24]<br />
17:42:03.681718 [DEBUG] TestThread: write some debug [25]<br />
17:42:03.692897 [DEBUG] TestThread: write some debug [26]<br />
17:42:03.704778 [DEBUG] TestThread: write some debug [27]<br />
17:42:03.715805 [DEBUG] TestThread: write some debug [28]<br />
17:42:03.727837 [DEBUG] TestThread: write some debug [29]<br />
17:42:03.738938 [INFO] TestThread: end<br />
17:42:03.743948 [INFO] Main: Let's disable now log to file<br />
17:42:03.788064 [INFO] Main: Let's enable again log to file<br />
17:42:03.799097 [INFO] Main: end<br />


