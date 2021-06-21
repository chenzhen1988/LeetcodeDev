[![Build status](https://ci.appveyor.com/api/projects/status/ovq8naak6atbjgv6/branch/main?svg=true)](https://ci.appveyor.com/project/chenzhen1988/leetcodedev/branch/main)
[![Build Status](https://travis-ci.com/chenzhen1988/LeetcodeDev.svg?branch=main)](https://travis-ci.com/chenzhen1988/LeetcodeDev)
# 1、Linux环境下编译运行

## 1.1、编译所有的target
```shell
./scons target=all -j24
或者
mkdir build && cd build && cmake .. -DT=all && make 
```

## 1.2、编译指定的target
```shell
./scons target=xxx -j24
或者
mkdir build && cd build && cmake .. -DT=xxx && make
```

## 1.3、运行
```shell
./main.exe
```

# 2、Windows环境下编译运行

## 2.1、 编译所有的target
```powershell
scons target=all -j24
```
## 2.2、 编译指定的target
```powershell
scons target=xxx -j24
```
## 2.3、 运行
```powershell
.\main.exe
```
