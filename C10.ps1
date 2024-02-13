$i=1
For(;$i -le 100;$i++) {
    ForEach-Object {
        New-Item -Path .\file$i.txt
        }
    }
