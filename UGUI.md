<a name="vzRFH"></a>
## **展史**
**UGUI是Unity引擎内自带的UI系统**<br />**官方称之为:Unity Ul**<br />**是目前Unity商业游戏开发中使用最广泛的U1系统开发解决方案它是基于Unity游戏对象的UI系统，只能用来做游戏U功能**<br />**不能用于开发Unity编辑器中内置的用户界面**

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713800939201-c1f06414-944f-4c60-b318-71b05ab375ea.png#averageHue=%23fbf2f1&clientId=uab8b3f7d-0057-4&from=paste&height=98&id=u69a4cc41&originHeight=246&originWidth=1201&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=110880&status=done&style=none&taskId=ud24691b3-1e39-49d0-94de-f6362261319&title=&width=476.3333740234375)<br />Unity最初版本~Unity4.6版本<br />Unity官方只提供了GUI用于游戏Ul的开发<br />所以更为高级和方便的NGUI是做UI的不二选择<br />Unity4.6版本以后<br />Unity官方招募NGUI作者加入Unity，协助Unity开发出UGUI系统用于游戏UI功能开发由于UGUI刚推出后功能不够完善，所以经历了较长的过渡期，几乎到Unity5的时代才开始正式全面普及<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713801001480-b0efe58b-2db3-4b55-92cc-d964dff8ccea.png#averageHue=%23f4f1f1&clientId=uab8b3f7d-0057-4&from=paste&height=357&id=u9e07a7d5&originHeight=582&originWidth=1212&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=275223&status=done&style=none&taskId=ue251bb2d-6b8b-4cb5-87f8-98a2a52a72e&title=&width=743.328125)<br />实例
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713801346501-9e8be11e-fca2-40ca-9bed-6a40718692f7.png#averageHue=%23504335&clientId=uab8b3f7d-0057-4&from=paste&height=555&id=uf642047d&originHeight=1065&originWidth=1891&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=1754045&status=done&style=none&taskId=u6b126f62-054e-47c5-9dfb-20ddfbcca10&title=&width=986)


<a name="BMPSp"></a>
# 六大基础组件
<a name="sYFxq"></a>
### 1.如何在unity中使用ugui
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713871567276-b1138d49-178a-4da8-937a-6a2842794277.png#averageHue=%235e5954&clientId=u4fd6b3dd-c2dc-4&from=paste&height=669&id=ua164914e&originHeight=1003&originWidth=1813&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=605050&status=done&style=none&taskId=uc68d3ef2-55fd-4dcb-acb5-760a872163b&title=&width=1208.6666666666667)<br />直接在hierarchy窗口中右键<br />选择ui   ui中所有内容都是ugui相关控件<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713873437251-37c82c52-6d52-4466-b7e5-8992a17984fc.png#averageHue=%23676666&clientId=u4fd6b3dd-c2dc-4&from=paste&height=510&id=ufb4e1213&originHeight=765&originWidth=630&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=177264&status=done&style=none&taskId=u7b0f9574-c678-4670-bb87-05e1f8fa1e2&title=&width=420)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713873670897-dd7e7b76-1490-4764-b524-628883ad907c.png#averageHue=%23d7d3cb&clientId=u4fd6b3dd-c2dc-4&from=paste&height=215&id=ub8f025d9&originHeight=519&originWidth=1048&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=226227&status=done&style=none&taskId=u36c237af-3423-4f61-8ea3-cebaf6bde8a&title=&width=435)
<a name="ISmb2"></a>
### 2.六大基础组件在哪里
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713873798225-37fe5add-8fef-435b-8558-5db3dda0bb7a.png#averageHue=%23f4edec&clientId=u4fd6b3dd-c2dc-4&from=paste&height=230&id=ub0336ebf&originHeight=745&originWidth=687&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=259836&status=done&style=none&taskId=u427c1fb8-52c1-4bb6-a59c-9a9036b484b&title=&width=212)
<a name="aMgI3"></a>
### 3.六大基础组件概述
<a name="BaHiE"></a>
#### Canvas对象上依附的：
**Canvas** : 画布组件，主要用于渲染ui控件<br />**Canvas Scaler** : 画布分辨率自适应组件，主要用于分辨率自适应<br />**Graphic Raycaster** : 射线事件交互组件，主要用于控制射线响应相关<br />RectTransform : ui对象位置锚点控制组件，主要用于控制位置和对其方式<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713874972013-6188ba68-2652-4ae9-af9e-b8cec887f87b.png#averageHue=%233d3d3d&clientId=u4fd6b3dd-c2dc-4&from=paste&height=601&id=ua5f8c3b7&originHeight=901&originWidth=546&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=124058&status=done&style=none&taskId=uc906cfe5-4a69-4748-9747-9a6eb980a6d&title=&width=364)
<a name="G2Z00"></a>
#### EventSystem对象上依附的：
在Canvas中创建UI对象   系统会自动创建一个EventSystem对象<br />**EventSystem和Standalone Input Module:**<br />玩家输入事件响应系统和独立输入模块组件，主要用于监听玩家操作<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713874989010-7cf93398-a837-4e3c-848b-8a713c5c359e.png#averageHue=%23393939&clientId=u4fd6b3dd-c2dc-4&from=paste&height=380&id=uec063aeb&originHeight=570&originWidth=550&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=80423&status=done&style=none&taskId=u6de4afba-0118-40c5-bd3b-1583f41270c&title=&width=366.6666666666667)
<a name="lFfRM"></a>
## Canvas渲染模式的控制
<a name="ahDbf"></a>
### 1.canvas组件用来干啥
> **canvas的意思是画布**
> 它是ugui中所有ui元素能够被显示的根本  它主要负责渲染自己的所有ui子对象

如果**ui控件对象**（image）不是canvas的子对象，**那么控件将不能被渲染（不可视）**<br />我们可以通过修改canvas组件上的参数修改渲染方式<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713875339761-eddb1513-5aac-495a-bc83-eaf5baab4405.png#averageHue=%23424242&clientId=u4fd6b3dd-c2dc-4&from=paste&height=96&id=u70a4c342&originHeight=144&originWidth=220&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=9939&status=done&style=none&taskId=ua8e0e999-cf95-40bd-9fee-22ef1782648&title=&width=147)<br />不可看见<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713875355518-5d5b4777-7d59-40cc-a8d5-cb823184c021.png#averageHue=%23414141&clientId=u4fd6b3dd-c2dc-4&from=paste&height=72&id=iLOEm&originHeight=108&originWidth=216&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=8162&status=done&style=none&taskId=uae7c9c2b-c092-4d7e-8584-50c27a66036&title=&width=144)<br />可看见
<a name="CKk5c"></a>
### 2.场景中可以有多个canvas对象
可以分别管理**不同画布的渲染方式**，分辨率适应方式等等参数<br />如果没有特殊需求<br />一般情况场景上一个canvas即可
<a name="zNwz0"></a>
### 3.canvas组件的3种渲染方式
![屏幕截图 2024-04-23 204203.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713876150710-bbf9ff79-91b3-48e7-abce-a9b8109c6ef1.png#averageHue=%237d7c7c&clientId=u4fd6b3dd-c2dc-4&from=ui&id=u69851540&originHeight=192&originWidth=556&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=22011&status=done&style=none&taskId=uce8b71ed-bf51-4d84-9697-fd7abef6431&title=)
<a name="KMaOp"></a>
#### Render Mode
<a name="gyFG4"></a>
##### Screen Space-Overlay：
介绍：屏幕空间，覆盖模式，ui始终在前

- **Pixel Perfect：** 是否开启无锯齿精确渲染（性能换效果）（一般不用，因为我们的图已经不错了）
- **Sort Order**：排序层编号（用于控制多个canvas时的**渲染先后顺序**）（数字越小先渲染，越后渲染的在前方 **数字大的在前面**）
- Target Display：目标设备（在哪个显示设备上显示）（用的少）
> ![切换设备后  需在Game窗口查看](https://cdn.nlark.com/yuque/0/2024/png/42440971/1723864093213-be25355d-ce7e-4670-aed8-0119600de595.png#averageHue=%23060606&clientId=u1cedf573-3084-4&from=paste&height=225&id=u5685df61&originHeight=225&originWidth=527&originalType=binary&ratio=1.5&rotation=0&showTitle=true&size=9337&status=done&style=none&taskId=ubb8429d2-770a-41d1-b32f-54fee348597&title=%E5%88%87%E6%8D%A2%E8%AE%BE%E5%A4%87%E5%90%8E%C2%A0%20%E9%9C%80%E5%9C%A8Game%E7%AA%97%E5%8F%A3%E6%9F%A5%E7%9C%8B&width=527 "切换设备后  需在Game窗口查看")

- Additional Shader Channels：其他着色器通道，决定着色器可以读取哪些数据（法线 切线之类）（暂时用不到）
<a name="YTMI3"></a>
##### Screen  Space-Camera：
介绍：屏幕空间，摄像机模式，3d物体可以显示在ui之前<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713877397495-6a12f18e-3fa9-461d-915f-9839d8396f6c.png#averageHue=%23494242&clientId=u4fd6b3dd-c2dc-4&from=paste&height=169&id=ubb492842&originHeight=265&originWidth=520&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=41691&status=done&style=none&taskId=ud7e3edbe-69f2-4555-bbd5-a1f27ecb37c&title=&width=331.66668701171875)

- **Render Camera:** 用于渲染ui的摄像机（如果不设置将和**覆盖模式一样的渲染**）（需要更改摄像机）
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1723865685572-fb768911-57e7-49b7-a897-ccd3a4ca6de5.png#averageHue=%2344423f&clientId=u1cedf573-3084-4&from=paste&height=62&id=uf7b010d0&originHeight=62&originWidth=301&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=6329&status=done&style=none&taskId=ufd496086-d4a1-44e5-9c23-b26049877a0&title=&width=301)


- **Plane Distance: **ui平面在摄像机前方的**距离**，类似整体z轴的感觉


**因为摄像机如果是主摄像机，可能会出现UI和场景物体重叠遮挡的情况**
> 解决是：
> 1. 单独申请一个摄像机，只渲染一个UI层
> 
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1723866367105-ee9ce5ea-581c-49d9-bc35-9037a424f0e2.png#averageHue=%23434343&clientId=u1cedf573-3084-4&from=paste&height=28&id=uc87d63fd&originHeight=28&originWidth=323&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=1694&status=done&style=none&taskId=u952dc0bb-7fa8-440e-99f5-2e02ae33397&title=&width=323)
> 2. 改变摄像机的层级，**主摄像机依然比UI摄像机小**
> 3. 不让UI摄像机渲染天空盒（？）
> 
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1723866549818-1d5ecb98-359a-414a-952b-eb4b2e9835f2.png#averageHue=%23807f7f&clientId=u1cedf573-3084-4&from=paste&height=129&id=uc78bfbdb&originHeight=129&originWidth=331&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=9691&status=done&style=none&taskId=uc926eea6-7f31-4456-bf4f-109627c6d47&title=&width=331)
> 4. 需要显示在UI前的物体单独去做

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1713879028047-afa45e72-3b2b-43c8-886d-8752a76aae8d.png#averageHue=%23625d57&clientId=u4fd6b3dd-c2dc-4&from=paste&height=566&id=u637619fd&originHeight=849&originWidth=1512&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=624068&status=done&style=none&taskId=u3f12b7af-4c8d-4312-af07-1ea3718a9b2&title=&width=1008)

- **Sorting Layer: **所在排序层（直接决定层级）
- **Order in layer: **排序层的序号（渲染先后  即同层级先后顺序）

**越大越前面**

<a name="OKccw"></a>
##### World Space：
介绍：世界空间，**3d模式**<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714217211708-4a6bda17-cec9-444b-a3af-e72aec89d7e9.png#averageHue=%23cdc4c1&clientId=uc2197d50-d4d2-4&from=paste&height=479&id=u24d1b5b8&originHeight=718&originWidth=1485&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=791229&status=done&style=none&taskId=u76914fce-7c89-4bbc-94f3-75716d7a04d&title=&width=990)

只有一个Event Camera不一样
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714217388882-36d779d8-f4f9-4a78-8b29-3b5b16ab8742.png#averageHue=%23434341&clientId=uc2197d50-d4d2-4&from=paste&height=62&id=u0a46852d&originHeight=93&originWidth=438&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=17228&status=done&style=none&taskId=u41a5910c-2f46-4040-9c47-569de9503c4&title=&width=292)
> 报错为 不关联摄像机就不会有反应 


一般关联的摄像机都是**主摄像机**<br />将UI当作3D物体处理（比例相同）
<a name="Rr5sG"></a>
### 总结
1.canvas组件用来干啥一画布组件，用于渲染显示ui控件，ui控件必须作为子<br />2.场景中可以有多个canvas对象一不同的渲染和分辨率适应方式（不常用）<br />3.canvas组件的3种渲染方式
> 覆盖模式：ui始终显示在最前面
> 摄像机模式：3d物体可以显示在ui之前
> 3d模式： 用于制作3d ui, **在vr和ar中常用**，游戏中的3dui效果才使用




<a name="Tnhx7"></a>
## Canvas Scaler ---- 分辨率自适应组件
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724508139361-5503831a-d9c1-4f18-8799-93870efe49a3.png#averageHue=%23f6efee&clientId=uc40c21d4-81b7-4&from=paste&height=394&id=ubca4f07e&originHeight=591&originWidth=1038&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=222744&status=done&style=none&taskId=ucac2363a-5f5b-464c-b917-28eff8e831c&title=&width=692) <br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714218053542-bfeaa221-31f3-417a-8caa-0b8e49051e99.png#averageHue=%233f3f3f&clientId=uc2197d50-d4d2-4&from=paste&height=112&id=ubc4d594d&originHeight=168&originWidth=523&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=18054&status=done&style=none&taskId=u012d62ef-4f60-43a8-8c79-1b4a8d055f6&title=&width=348.6666666666667)
<a name="nJLqu"></a>
### 1.Canvas Scaler 组件干啥
Canvas Scaler意思是**画布缩放控制器 **<br />它是用于分辨率自适应的组件

它主要**负责在不同分辨率下ui控件大小自适应**<br />它不负责**位置**，位置由之后的RectTransform组件负责

它主要提供了三种用于分辨率自适应的模式<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714218249712-fc6f7beb-3a6d-4d6f-862e-8208a1cd885e.png#averageHue=%23494a48&clientId=uc2197d50-d4d2-4&from=paste&height=80&id=u358ba563&originHeight=120&originWidth=495&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=63511&status=done&style=none&taskId=ucad99a88-41ee-46ae-a548-bc3217e9340&title=&width=330)<br />我们可以选择符合我们项目需求的方式进行分辨率自适应
<a name="uSNZ2"></a>
### 2.Canvas Scaler组件学前准备
<a name="Z66nV"></a>
#### 屏幕分辨率：
Game 窗口中的 Stats 统计数据窗口<br />看到的当前"屏幕"分辨率<br />会参与分辨率自适应的计算<br />![屏幕截图 2024-04-27 194528.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714218359921-f922806b-b3e8-488d-a270-18b28dfd9282.png#averageHue=%232a2a29&clientId=uc2197d50-d4d2-4&from=ui&height=339&id=u21f05f96&originHeight=460&originWidth=594&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=75939&status=done&style=none&taskId=u5c1eadd8-fe89-4b8d-8050-1fd7fd080ca&title=&width=438)<br />通过Game查看分辨率<br />拖动窗口可以看见分辨率在改变

<a name="ek0yG"></a>
#### 画布大小和缩放系数：
选中Canvas对象后在Rect Transform组件中看到的宽高和缩放<br />**宽高*缩放系数 = 屏幕分辨率**

<a name="DT29K"></a>
#### Reference Resolution:
在第二种 **UI Scale Mode **<br />参考分辨率<br />在缩放模式的宽高模式中出现的参数，参与分辨率自适应的计算<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714219334126-3ec65062-0a29-43a5-a76a-e8e5b5dbf628.png#averageHue=%23c2c0c0&clientId=uc2197d50-d4d2-4&from=paste&height=230&id=u3449ec3f&originHeight=448&originWidth=834&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=206952&status=done&style=none&taskId=uc8d27c11-4585-4071-80f0-7ed016ac1fe&title=&width=428)
<a name="f9jN8"></a>
#### 汇总
屏幕分辨率----当前设备的分辨率，编辑器下game窗口中可以查看到<br />参考分辨率----在其中一种适配模式中出现的关键参数，参与分辨率自适应的计算<br />画布宽高和缩放系数----分辨率自适应会改变的参数，通过屏幕分辨率和参考分辨率计算而来<br />分辨率大小自适应----通过一定的算法以屏幕分辨率和参考分辨率参与计算得出缩放系数<br />该结果会影响所有ui控件的缩放大小<br />**屏幕大的时候，按钮大，屏幕小的时候，按钮小**

<a name="hdFq8"></a>
### 3.CanvasScaler的三种适配方式
Constant pixel size(恒定像素模式）:无论屏幕大小如何，ui始终保持相同像素大小<br />Scale With screen size(缩放模式）:根据屏幕尺寸进行缩放，随着屏幕尺寸放大缩小<br />Constant Physical size(恒定物理模式）:无论屏幕大小和分辨率如何，ui元素始终保持相同物理大小

<a name="CBQu8"></a>
#### Canvas Scaler ---- 恒定像素模式
> 无论屏幕大小如何，ui始终保持相同像素大小进行显示
> 一般不用

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714221010309-bbddc32a-8ecb-48e5-aeb9-0de661dff3a5.png#averageHue=%233a3a3a&clientId=uc2197d50-d4d2-4&from=paste&height=117&id=u21a2b8a7&originHeight=175&originWidth=841&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=27767&status=done&style=none&taskId=u6a405070-e695-4543-940c-f6e2e41f699&title=&width=560.6666666666666)<br />**Scale factor**：缩放系数，按此系数缩放**画布**中的所有ui元素<br />**Reference pixels per unit**：单位参考像素，多少像素对应unity中的一个单位（默认一个单位为100像素）<br />图片设置中的Pixels Per Unit设置，会和该参数一起参与计算

**UI中投入图片要先改图片类型 Sprite**
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714221952735-4af59b99-c2dd-4799-b007-ebf68c45dedd.png#averageHue=%238d8c8a&clientId=uc2197d50-d4d2-4&from=paste&height=169&id=uf4175b55&originHeight=253&originWidth=310&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=55861&status=done&style=none&taskId=u56aa4b0c-a284-4afa-8dfb-6c7cab66dc0&title=&width=206.66666666666666)
> 而后引用
> 拖入image
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714222134207-42c3426b-cd93-4127-b90e-9ba753fb3cbf.png#averageHue=%23464646&clientId=uc2197d50-d4d2-4&from=paste&height=31&id=u30f91620&originHeight=46&originWidth=276&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=9345&status=done&style=none&taskId=u5337e9b1-c25c-40fa-9df3-2a357c0e73a&title=&width=184)
> 恢复图片原始尺寸
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714222244618-1b97f2c8-7e6d-4165-8ecf-9737f3259dc5.png#averageHue=%23b3aeae&clientId=uc2197d50-d4d2-4&from=paste&height=387&id=u9b3a426f&originHeight=580&originWidth=1447&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=319828&status=done&style=none&taskId=ucdd138b7-8030-40dd-9800-e4f8c983d2a&title=&width=964.6666666666666)

<a name="mfQCO"></a>
##### 总结
恒定像素模式<br />它不会让ui控件进行分辨率大小自适应<br />会让ui控件始终保持设置的尺寸大小显示

一般在进行游戏开发**极少使用这种模式**<br />除非通过代码计算来设置缩放系数

<a name="mkjfB"></a>
#### Canvas Scaler ---- 缩放模式
Scale With screen size(缩放模式）
> 根据屏幕尺寸进行缩放，随着屏幕尺寸放大缩小
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714227445652-319cb9b6-8f41-47a2-bcfb-81e00ad241c8.png#averageHue=%233f3f3f&clientId=u2035a7c5-0e06-4&from=paste&height=149&id=u59eeffd5&originHeight=224&originWidth=582&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=28256&status=done&style=none&taskId=u4641dd90-810f-4a31-bbc0-304486ae614&title=&width=388)

<a name="ECUJj"></a>
##### Reference Resolution : 参考分辨率 
（美术同学出图的标准分辨率）。缩放模式下的所有匹配模式都会基于参考分辨率进行自适应计算（1920*1080  16：9）
<a name="h48pK"></a>
##### Screen match mode : 屏幕匹配模式，
当前屏幕分辨率宽高比不适应参考分辨率时，用于分辨率大小自适应的匹配模式
> Expand：水平或垂直拓展画布区域，会根据宽高比的变化来放大缩小画布，可能有黑边
> Shrink：水平或垂直裁剪画布区域，会根据宽高比的变化来放大缩小画布，可能会裁剪
> Match Width Or Height：以宽高或者二者的平均值作为参考来缩放画布区域

<a name="loQwT"></a>
###### Expand 
拓展匹配 ：<br />将canvas size进行宽或高扩大，让他高于参考分辨率<br />计算公式：<br />缩放系数 = Mathf.min(屏幕宽/参考分辨率宽，屏幕高/参考分辨率高）;<br />画布尺寸 = 屏幕尺寸 / 缩放系数<br />表现效果：最大程度的缩小ui元素，**保留ui控件所有细节，可能会留黑边**<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714385406188-3eaec158-ff0e-4233-bb72-595b8d879de3.png#averageHue=%23404040&clientId=ud76c38a2-6068-4&from=paste&height=248&id=u3506be7b&originHeight=273&originWidth=526&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=25719&status=done&style=none&taskId=u85ef4665-01db-4a41-ae8f-ca28dd41f0a&title=&width=477.66668701171875)<br />示例<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714387468099-48f33e5e-42ed-473f-af86-df85ce758dd8.png#averageHue=%23f7edec&clientId=ud76c38a2-6068-4&from=paste&height=283&id=u2590392b&originHeight=673&originWidth=1282&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=478379&status=done&style=none&taskId=u83d02072-e83a-4631-bdc7-2156072e05a&title=&width=539)
<a name="cWnXx"></a>
###### shrink
收缩匹配<br />将canvassize进行宽或高收缩，让他低于参考分辨率<br />计算公式：<br />缩放系数 = mathf.max(屏幕宽/参考分辨率宽，屏幕高/参考分辨率高）;<br />画布尺寸 = 屏幕尺寸/缩放系数<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714390362971-2f2d78f1-e3e7-489e-9085-8eb91c658450.png#averageHue=%233d3d3d&clientId=ud76c38a2-6068-4&from=paste&height=147&id=u994ac736&originHeight=221&originWidth=583&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=11645&status=done&style=none&taskId=ua2b572d9-635d-405f-966b-39d42f3bc76&title=&width=388.6666666666667)<br />表现效果：最大程度的放大ui元素，让ui元素能够填满画面，可能会出现**裁剪**<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1714390433447-902b82e3-fa5a-462b-9cdd-51a74b229c06.png#averageHue=%23f8efee&clientId=ud76c38a2-6068-4&from=paste&height=302&id=u34cda93a&originHeight=692&originWidth=1308&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=449704&status=done&style=none&taskId=ube565c8e-07c9-48c0-becc-352f58ed959&title=&width=571)

<a name="IAD9G"></a>
###### Match Width Or Height:(高频)
以宽高或者二者的平均值作为参考来缩放画布区域<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724551171438-a213f1ef-0f2b-4d9b-876b-12abfcf4afc9.png#averageHue=%23404040&clientId=u2dc8dcc9-69ca-4&from=paste&height=147&id=u320e58c9&originHeight=220&originWidth=546&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=29707&status=done&style=none&taskId=u6961cd08-52f9-4fc8-b3d0-1c8e1f37d56&title=&width=364)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724551180697-9e05ea07-b8c5-4e3f-aaac-50cda51a30c0.png#averageHue=%23f1eae9&clientId=u2dc8dcc9-69ca-4&from=paste&height=254&id=u7db9d65f&originHeight=381&originWidth=1226&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=256134&status=done&style=none&taskId=u48e36c2b-1d43-4718-80b4-22be10f444b&title=&width=817.3333333333334)

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724551208585-5915435a-4c40-4d3a-bd97-c5499ceafeb0.png#averageHue=%23e3e1e1&clientId=u2dc8dcc9-69ca-4&from=paste&height=536&id=ua9ea5b8c&originHeight=804&originWidth=1680&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=480461&status=done&style=none&taskId=u7ae1dfd8-7834-4fc6-adb8-d81b55626f8&title=&width=1120)

表现效果<br />主要用于只有横屏模式或者竖屏模式的游戏

**竖屏游戏:**Match=0<br />将画布宽度设置为参考分辨率的宽度<br />并保持比例不变<br />屏幕越高可能会有黑边

**横屏游戏:**Match=1<br />将画布高度设置为参考分辨率的高度<br />并保持比例不变，屏幕越长可能会有黑边

<a name="qjhPX"></a>
#### <br />
<a name="O5QfS"></a>
##### 总结
游戏开发一般使用<br />Scale With Screen Size 缩放模式

存在横竖屏切换选择
> Expand(拓展匹配，有黑边)
> Shrink(收缩匹配，有裁剪)

不存在横竖屏切换(定死的横屏或者竖屏游戏)
> Match Width Or Height:

<a name="VL8Dq"></a>
#### CanvasScaler--恒定物理模式
无论屏幕大小和分辨率如何，UI元素始终保持相同物理大小<br />恒定物理尺寸模式（简称：恒定物理模式）<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724552478911-e813714c-58c4-4eaa-a5b2-464771ae52ad.png#averageHue=%233d3d3d&clientId=u2dc8dcc9-69ca-4&from=paste&height=175&id=u4ae38bcd&originHeight=263&originWidth=531&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=30791&status=done&style=none&taskId=u1cd2158f-420b-48b3-824a-7a82bd6bf64&title=&width=354)<br />DPI：（Dots Per Inch，每英寸点数）图像每英寸长度内的像素点数 <br />Physical Unit：物理单位，使用的物理单位种类 <br />Fallback Screen DPI：备用DPI，当找不到设备DPI时，使用此值 <br />Default Sprite DPI：默认图片DPI <br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724552707234-b8610951-e3bf-4622-b4dd-95881aadc826.png#averageHue=%23f5edec&clientId=u2dc8dcc9-69ca-4&from=paste&height=406&id=u399ae625&originHeight=609&originWidth=911&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=264821&status=done&style=none&taskId=u84900b83-8c63-47cc-b1c7-fd16b47b038&title=&width=607.3333333333334)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724552690820-200ef071-d589-48d5-a2d7-ee68946cdf79.png#averageHue=%237b7b7b&clientId=u2dc8dcc9-69ca-4&from=paste&height=161&id=uc8661f74&originHeight=241&originWidth=535&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=24538&status=done&style=none&taskId=ucebfda1a-e4a7-44c6-8879-bd8aa7ae369&title=&width=356.6666666666667)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724552665771-9d9879f6-add4-4a64-a4d4-b78a81791dcf.png#averageHue=%23bfcae3&clientId=u2dc8dcc9-69ca-4&from=paste&height=336&id=u496fcedd&originHeight=504&originWidth=957&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=138147&status=done&style=none&taskId=u4b857a66-c9eb-4cf2-b1b3-bfbb02dbc48&title=&width=638)
<a name="BLhOc"></a>
##### 恒定像素模式和恒定物理模式区别
相同点:他们都不会进行缩放，图片有多大显示多大，使用他们不会进行分辨率大小自适应<br />不同点:相同尺寸不同DPI设备像素点区别，像素点越多细节越多<br />同样为5像素，DPI较低的设备上看起来的尺寸可能会大于DPI较高的设备
<a name="Itv6W"></a>
##### 总结 
恒定物理模式 <br />它不会让UI控件进行分辨率大小自适应 <br />会让UI控件始终**保持设置的尺寸大小显示 **<br />而且会根据设备DPI进行计算，让在不同设备上的显示大小更加准确 <br />一般在进行游戏开发极少使用这种模式
<a name="JU5LJ"></a>
### 4.CanvasScaler 3D模式
世界模式（3D模式）<br />藏起来了的特殊模式<br />只在World Space中强制出现<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724553321858-48c78426-5ad1-4f62-8fd3-352902c6847c.png#averageHue=%233a3a3a&clientId=u2dc8dcc9-69ca-4&from=paste&height=112&id=u09fea3db&originHeight=168&originWidth=529&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=14640&status=done&style=none&taskId=ue29b7705-1a24-4de1-99be-4f16e2035b8&title=&width=352.6666666666667)
<a name="nKMwZ"></a>
#### Dynamic Pixels Per Unit：
Ul中动态创建的位图(例如文本)中，单位像素数(类似密度)
<a name="cRVxn"></a>
#### Reference Pixels Per Unit
单位参考像素，多少像素对应Unity中的一个单位(默认一个单位为100像素)

只有在3D渲染模式下才会启用的模式<br />主要用于控制该模式下的像素密度

<a name="K838S"></a>
## Grephic Raycaster
<a name="tPWAe"></a>
### Graphic Raycaster作用
Graphic Raycaster意思是图形射线投射器<br />它是用于检测UI输入事件的射线发射器

它主要负责通过射线检测玩家和UI元素的交互<br />判断是否点击到UI元素
<a name="RZhBK"></a>
### Graphic Raycaster参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724554094954-21f0bd3d-ed4e-4098-b31a-57fadb44ee4c.png#averageHue=%23404040&clientId=u2dc8dcc9-69ca-4&from=paste&height=144&id=u2a9a8a44&originHeight=216&originWidth=544&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=25748&status=done&style=none&taskId=uea0b4668-3eec-4c8c-aed3-a3d89db3adf&title=&width=362.6666666666667)<br />lgnore Reversed Graphics：是否忽略反转图形（与x y 轴有关）<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724584605145-1efdd5c2-13d1-48cd-924b-826bbbb11518.png#averageHue=%233a3a3a&clientId=u2dc8dcc9-69ca-4&from=paste&height=44&id=u4709203a&originHeight=66&originWidth=360&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=4501&status=done&style=none&taskId=u380f63f4-fcfa-4026-bbb6-a5616582292&title=&width=240) <br />Blocking Objects :  射线被哪些类型的碰撞器阻挡(在覆盖渲染模式下无效)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724584588925-7c9b4ceb-98c7-4540-871c-d943267a5ed5.png#averageHue=%23646363&clientId=u2dc8dcc9-69ca-4&from=paste&height=171&id=uc280be72&originHeight=256&originWidth=543&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=17750&status=done&style=none&taskId=u33e3d3eb-9afa-4d8b-985e-12ffb632dd0&title=&width=362)<br />Blocking Mask :  射线被哪些层级的碰撞器阻挡(在覆盖渲染模式下无效)

<a name="RSjsl"></a>
## EventSystem 以及 Standalone Input Module
<a name="CHc4Z"></a>
### EventSystem组件用来干啥的
Event System意思是事件系统

它是**用于**<br />管理玩家的输入事件并分发给各UI控件

它是**事件逻辑处理模块**<br />所有的UI事件都通过EventSystem组件中轮询检测并做相应的执行<br />它类似一个中转站，和许多模块一起共同协作

如果没有它 所有的点击 拖拽等等行为都不会被响应
<a name="LroWx"></a>
### EventSystem组件参数
First Selected：首先选择的游戏对象，可以设置游戏一开始的**默认选择**<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724591674792-f540ca8a-3950-4672-9c3a-b8eacc441926.png#averageHue=%233b3b3b&clientId=u2dc8dcc9-69ca-4&from=paste&height=116&id=u71783048&originHeight=174&originWidth=534&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=22196&status=done&style=none&taskId=u8b192807-ef42-4479-914d-6863e4ac204&title=&width=356)<br />Send Navigation Events：是否允许导航事件(移动/按下/取消)<br />Drag Threshold：拖拽操作的阈值(移动多少像素算拖拽)
<a name="wBPoq"></a>
### Standalone Input Module组件用来干啥的
Standalone lnput Module意思是<br />独立输入模块

它**主要针对**<br />处理鼠标/键盘/控制器/触屏(新版Unity)的输入<br />输入的事件通过EventSystem进行分发  **响应UI中的事件**<br />它依赖于EventSystem组件，他们两缺一不可
<a name="Lh0pY"></a>
### Standalone Input Module组件参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724595097360-568dad39-8c13-4184-94ef-5b1ce8824512.png#averageHue=%23373737&clientId=u2dc8dcc9-69ca-4&from=paste&height=217&id=u98e659b7&originHeight=325&originWidth=540&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=38600&status=done&style=none&taskId=uaa61eac4-87de-4fea-a248-eff04f35b3c&title=&width=360)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724595234937-35fabb78-5a2f-468f-9ff7-a42b2ff3f898.png#averageHue=%233a3a3a&clientId=u2dc8dcc9-69ca-4&from=paste&height=731&id=u5a173afa&originHeight=731&originWidth=1170&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=101839&status=done&style=none&taskId=u3a23d362-99e6-4cb2-b6d8-3fc2b5525e7&title=&width=1170)<br />管理器在 Project Settings <br />Horizontal Axis：水平轴按钮对应的热键名(该名字对应Input管理器)<br />Vertical Axis：垂直轴按钮对应的热键名(该名字对应Input管理器<br />Submit Button：提交(确定)按钮对应的热建名(该名字对应Input管理器)<br />Cancel Button：取消按钮对应的热建名(该名字对应Input管理器<br />Input Actions Per Second：每秒允许键盘/控制器输入的数量<br />Repeat Delay：每秒输入操作重复率生效前的延迟时间<br />ForceModule Active：是否强制模块处于激活状态

<a name="q2xeS"></a>
## RectTransform位置锚点组件
<a name="p2XG8"></a>
### 1.RectTransform组件用来干啥
RectTransform意思是矩形变换<br />它继承于Transform<br />是专门用于处理UI元素位置大小相关的组件  

Transform组件只处理位置、角度、缩放<br />RectTransform 继承了Transform 在此基础上加入了矩形相关，将UI元素当做一个矩形来处理<br />加入了中心点、锚点、长宽等属性<br />其目的是更加方便的控制其大小以及分辨率自适应中的位置适应
<a name="mKwp3"></a>
### 2.RectTransform组件参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724597151217-f8acb011-5934-458c-89da-98af0a59ed21.png#averageHue=%233a3a3a&clientId=u2dc8dcc9-69ca-4&from=paste&height=228&id=ue482ace7&originHeight=342&originWidth=542&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=28059&status=done&style=none&taskId=udc73c595-2c83-4547-a221-f1d5ad11505&title=&width=361.3333333333333)<br />一般都是用**点类型**

Pivot：轴心(中心)点，取值范围0~1<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724598092356-6297a7df-b45d-4567-9e37-3b09980f13c9.png#averageHue=%23e1e3e0&clientId=u2dc8dcc9-69ca-4&from=paste&height=147&id=ucaf4fb09&originHeight=221&originWidth=270&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=17450&status=done&style=none&taskId=u03cb7d5c-afdc-487f-8e87-2c5d705148a&title=&width=180)<br />Rotation：围绕**轴心点**旋转的角度<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724598165452-7f58d1ac-d5f0-48a2-9d9d-643e85714d9c.png#averageHue=%23eaecea&clientId=u2dc8dcc9-69ca-4&from=paste&height=170&id=EkqVJ&originHeight=255&originWidth=343&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=33444&status=done&style=none&taskId=u282467e8-4158-4f5d-9146-73e85893630&title=&width=228.66666666666666)<br />Anchors(相对父矩形**锚点**)：<br />Min是矩形锚点范围X和Y的最小值<br />Max是矩形锚点范围X和Y的最大值<br />取值范围都是0~1<br />Pos(X,YZ)：轴心点(中心点)相对锚点的位置<br />**主要和分辨率位置自适应有关**

Width/Height：矩形的宽高<br />Left/Top/Right/Bottom：矩形边缘相对于锚点的位置;当锚点分离时会出现这些内容<br />![和父对象大小一致 也就是图片会变形](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724601233490-d1290497-9690-4627-9a3d-aba6347a3d85.png#averageHue=%23353535&clientId=u2dc8dcc9-69ca-4&from=paste&height=172&id=MzsXt&originHeight=258&originWidth=357&originalType=binary&ratio=1.5&rotation=0&showTitle=true&size=11755&status=done&style=none&taskId=ucef318a5-3ab3-4105-bc7e-5398f69c7f4&title=%E5%92%8C%E7%88%B6%E5%AF%B9%E8%B1%A1%E5%A4%A7%E5%B0%8F%E4%B8%80%E8%87%B4%20%E4%B9%9F%E5%B0%B1%E6%98%AF%E5%9B%BE%E7%89%87%E4%BC%9A%E5%8F%98%E5%BD%A2&width=238 "和父对象大小一致 也就是图片会变形")

缩放大小<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724601976998-90f42737-f8ec-497b-8065-be68454817ba.png#averageHue=%23525252&clientId=u2dc8dcc9-69ca-4&from=paste&height=20&id=u8b357367&originHeight=30&originWidth=39&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=481&status=done&style=none&taskId=u96dc10e9-7884-4220-b26f-169eb31ef19&title=&width=26) Blueprint Mode(蓝图模式  快捷键 **t**  )：启用后，编辑旋转和缩放不会影响矩形，只会影响显示内容<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724601966746-a8f2d78d-ceb7-4c9e-911a-92a70b145683.png#averageHue=%233e4d5d&clientId=u2dc8dcc9-69ca-4&from=paste&height=26&id=u6ec29657&originHeight=39&originWidth=43&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=562&status=done&style=none&taskId=ufebfae59-356d-4c54-aed5-3c95501a15e&title=&width=28.666666666666668) Raw Edit Mode(原始编辑模式)：启用后，改变轴心和锚点值不会改变**矩形位置**

<a name="TEWYg"></a>
#### 快捷设置
点击左上角方框，将出现锚点中心点快捷设置面板<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724602113768-d8c59e7c-0b0b-4f87-b788-abd449b476c5.png#averageHue=%233d3c3c&clientId=u2dc8dcc9-69ca-4&from=paste&height=79&id=ub4d2ace1&originHeight=119&originWidth=147&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=2375&status=done&style=none&taskId=ue0187499-9e58-4d03-bdce-f39f971120f&title=&width=98)<br />按住Shift点击鼠标左键可以同时设置**轴心点**(相对自身矩形)<br />按住Alt点击鼠标左键可以同时设置**位置**<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724602129096-d7763cf7-39c4-4db0-a534-1b6bee5c1321.png#averageHue=%233d3c3c&clientId=u2dc8dcc9-69ca-4&from=paste&height=381&id=uc643c1c2&originHeight=572&originWidth=485&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=29568&status=done&style=none&taskId=uf5d1576f-b096-4859-ae1e-68a3f0a1e5e&title=&width=323.3333333333333)

<a name="lmkmz"></a>
# 三大基础控件
<a name="l6WAS"></a>
## Image图片
<a name="lSinl"></a>
### 参数相关
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724603239666-659e61da-b046-46cc-93dd-0617d073c5aa.png#averageHue=%23444444&clientId=u2dc8dcc9-69ca-4&from=paste&height=186&id=u3ba921c2&originHeight=279&originWidth=634&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=27860&status=done&style=none&taskId=u66f8d8c6-a758-47d2-8551-b2d30444b20&title=&width=422.6666666666667)
<a name="I1Ttv"></a>
#### Source lmage:  图片来源(图片类型必须是”精灵“类型)
<a name="U4x95"></a>
#### Color:  图像的颜色
<a name="uQDVf"></a>
#### Material:  图像的材质(一般不修改，会使用UI的默认材质）
<a name="qfAGS"></a>
#### Raycast Target:  是否作为射线检测的目标(如果不勾选将不会响应射线检测)
![点不到点不到](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724604000062-861f0d0c-bb32-48e0-8961-a4ee017a0f47.png#averageHue=%23c7dfe7&clientId=u2dc8dcc9-69ca-4&from=paste&height=197&id=u1a77fd08&originHeight=299&originWidth=390&originalType=binary&ratio=1.5&rotation=0&showTitle=true&size=115552&status=done&style=none&taskId=u90514808-6dd8-4808-a446-08ef7a98a9e&title=%E7%82%B9%E4%B8%8D%E5%88%B0%E7%82%B9%E4%B8%8D%E5%88%B0&width=257 "点不到点不到")
<a name="pUjkj"></a>
#### Maskable:  是否能被遮罩(之后结合遮罩相关知识点进行讲解)
**越上面的越后面**

<a name="XeIx9"></a>
#### lmage Type:图片类型
<a name="QxPsO"></a>
##### Simple-普通模式，均匀缩放整个图片
<a name="fg2iu"></a>
##### Sliced-切片模式，9宫格拉伸，只拉伸中央十字区域
> Pixels Per UnitMultiplier：每单位像素乘数
> Fil Center：中心填充

<a name="miKOV"></a>
##### Tiled-平铺模式，重复平铺中央部分
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724604753536-a8003573-4cd1-498e-8743-b185ebeed99d.png#averageHue=%23253f1f&clientId=u2dc8dcc9-69ca-4&from=paste&height=255&id=uad66a8ae&originHeight=383&originWidth=433&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=59906&status=done&style=none&taskId=u0e31e521-c5c7-491e-9554-06f5732a19d&title=&width=288.6666666666667)

<a name="hOVT5"></a>
##### Filled-填充模式
> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724604938220-fbf68866-6e16-4519-8eab-d4dd46947360.png#averageHue=%23414141&clientId=u2dc8dcc9-69ca-4&from=paste&height=156&id=ueb48e7a6&originHeight=234&originWidth=605&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=21167&status=done&style=none&taskId=ub25db5bc-5e55-4fdd-ac74-d858a3c4e68&title=&width=403.3333333333333)
> Fill Method:填充方式
> Fill Origin:填充原点
> Fill Amount:填充量
> Clockwise:顺时针方向
> **Preserve Aspect:保持宽高比**

切换类型<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724604414173-3a6f7d4f-aef1-4145-a594-2f6846f9dca2.png#averageHue=%233f3f3f&clientId=u2dc8dcc9-69ca-4&from=paste&height=211&id=u0a8f35a0&originHeight=317&originWidth=584&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=29559&status=done&style=none&taskId=u3529b88f-fa90-4892-a587-bca5309a75a&title=&width=389.3333333333333)

<a name="zXOmE"></a>
#### Use Sprite Mesh:使用精灵网格，勾选的话Unity会帮我们生成图片网格
<a name="ChpF5"></a>
#### Preserve Aspect:确保图像保持其现有尺寸
<a name="EY8am"></a>
#### Set Native Size:设置为图片资源的原始大小
<a name="QajOL"></a>
#### 代码控制
UI 需要引用**using UnityEngine.UI;**
<a name="fVbgu"></a>
## Text文本控件
Text是文本组件<br />是UGUI中用于显示文本的关键组件

MeshPro暂时不用
<a name="dZbMl"></a>
### Text参数相关
<a name="uXbsJ"></a>
#### Text：文本显示内容
<a name="JFXvF"></a>
#### Font：字体
C:\Windows:\Fonts
<a name="AEGQN"></a>
#### Normal：普通
<a name="hA8EW"></a>
#### FontStyle：字体样式
> Bold:加粗
> ltalic: 斜体
> Bold And ltalic: 加粗 + 斜体


<a name="dNY1g"></a>
#### Font size：字体大小
<a name="PknNL"></a>
#### Line Spacing：行之间的垂直间距
<a name="Rop7n"></a>
#### Rich Text：是否开启富文本
<a name="dRVPi"></a>
#### Alignment：对qi方式
Align By Geometry：使用字形集合形状范围进行水平对其，而不是字<br />形指标
<a name="C97RH"></a>
#### Horizontal Overflow：处理文本太宽无法放入矩形范围内时的处理方
式<br />Wrap:包裹模式-字体始终在矩形范围内，会自动换行<br />Overflow:溢出模式-字体可以溢出矩形框<br />Truncate:截断模式-字体始终在矩形范围内，超出部分裁剪

<a name="rLB0d"></a>
#### Vertical overflow：处理文本太高无法放入矩形范围内时的处理方式、
Truncate:截断模式-字体始终在矩形范围内超出部分裁剪<br />Overflow:溢出模式-字体可以溢出矩形框

<a name="zxEbi"></a>
#### Best Fit：忽略字体大小，始终把内容完全显示在矩形框中，会自动调整字体大小
MinSize:最小多小<br />MaxSize:最大多大

<a name="FvOPA"></a>
#### Raycast Padding
射线检测  会被矩形所有的区域影响


<a name="cYkPj"></a>
### 富文本
类似https<br />**加粗**<b>文本内容</b><br />**斜体**<i>文本内容</i><br />**大小**<size=50>文本内容</size><br />**颜色**<br /><color=#ff0000ff>文本内容</size><br /><color=red>文本内容</size><br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724684513154-2b9e5748-1629-4888-aefd-5054ed6d5967.png#averageHue=%23353535&clientId=uf2696586-d142-4&from=paste&height=90&id=u2b1f193e&originHeight=123&originWidth=357&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=7192&status=done&style=none&taskId=u2bb1e7e2-1d59-463d-8bd1-4d65d143169&title=&width=262)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724684558798-567a3d8e-22f4-4e16-b38b-06d71cc66ce8.png#averageHue=%23717983&clientId=uf2696586-d142-4&from=paste&height=174&id=ud48a76cf&originHeight=358&originWidth=633&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=68461&status=done&style=none&taskId=u6a001704-0baa-433b-88d0-fa3532dc845&title=&width=307)

颜色对应<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724684724584-34b40380-140f-4eb0-9cd3-d43044f849e1.png#averageHue=%23faf9f9&clientId=uf2696586-d142-4&from=paste&height=308&id=u21163836&originHeight=462&originWidth=479&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=76514&status=done&style=none&taskId=u4308e17d-dfe2-4e55-97a7-59151626db5&title=&width=319.3333333333333)

<a name="pPDNS"></a>
### 边缘线和阴影
在ugui通过脚本来更改<br />边缘线组件 **outline** ---- 可以设置颜色 透明度 <br />阴影组件 **Shadow**  ---- 可以设置颜色 距离
<a name="icxww"></a>
## Rawimage大图控件
RawImage是原始图像组件<br />是UGUI中用于显示任何纹理图片的关键组件

它和Image的区别是 一般RawImage用于显示**大图**(背景图，不需要打入图集的图片，网络下载的图等等)
<a name="cSL4X"></a>
### Texture :
图像纹理
<a name="tpTyE"></a>
### UV Rect：
图像在UI矩形内的偏移和大小<br />位置偏移X和Y(取值0~1)<br />大小偏移W和H(取值0~1)<br />改变他们图像边缘将进行拉伸来填充UV矩形周围的空间

<a name="vPIPq"></a>
#  组合控件
<a name="pUd8G"></a>
## Button----按钮
<a name="ZYE57"></a>
### Button是什么
Button是按钮组件<br />是UGUI中用于**处理玩家按钮相关交互的关键组件**

默认创建的Button由2个对象组成<br />父对象——Button组件依附对象 同时挂载了一个Image组件 作为按钮背景图<br />子对象——按钮文本（可删）<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724686476614-42f57dd1-f294-4e3c-b726-d9844e1cb286.png#averageHue=%23494949&clientId=uf2696586-d142-4&from=paste&height=54&id=u3a7197aa&originHeight=81&originWidth=241&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=10337&status=done&style=none&taskId=ucd208fdf-003b-4f98-86ff-576e6d8f7fd&title=&width=160.66666666666666)
<a name="rAK8A"></a>
### Button参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724686971987-4f2a2ea7-643f-43f5-90b4-7a046e087cd8.png#averageHue=%233e3e3e&clientId=uf2696586-d142-4&from=paste&height=236&id=u5c61d498&originHeight=354&originWidth=735&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=20719&status=done&style=none&taskId=udea0539a-8d0f-4f3a-8013-544a4ec092e&title=&width=490)
<a name="RHMQq"></a>
#### Interactable ---- 是否接受输入
<a name="MMLLO"></a>
#### Transition ---- 响应用户输入的过渡效果
<a name="pgK7P"></a>
##### None
没有任何效果
<a name="dDTOb"></a>
##### Color Tint ---- 用颜色表示不同状态的变化
Target Graphic：控制的目标图形（还可以选择文本）<br />Normal Color：正常状态颜色<br />Highlighted Color：鼠标进入时显示高亮颜色<br />Pressed Color：按下颜色<br />Selected Color：选中的颜色<br />Disabled Color：禁用时的颜色<br />Color Multiplier：颜色倍增器，过渡颜色乘以该值（看不出来）<br />FadeDuration：衰减持续时间，从一个状态进入另一个状态时需要的时间
<a name="ctMzw"></a>
##### Sprite Swap ---- 用图片表示不同状态的变化
Highlighted Sprite：选中时图片<br />Pressed Sprite：按下时图片<br />Disabled Sprite：禁用时显示的图片
<a name="c0mQJ"></a>
##### Animation ---- 用动画表示不同状态的变化
Normal Trigger:正常动画触发器<br />Highlighted Trigger:鼠标进入状态时触发器<br />Pressed Trigger:按下时触发器<br />Selected Trigger:选中时触发器<br />Disabled Trigger:禁用时触发器
<a name="uA438"></a>
#### Navigation ---- 导航模式，可以设置UI元素如何在播放模式中控制导航
在EventSystem中开启导航事件

None:无键盘导航<br />Horizontal:水平导航<br />Verticval:垂直导航<br />Automatic:自动导航<br />Explicit:指定周边控件进行导航
<a name="X1NHE"></a>
#### OnClick:单击(按下再抬起)执行的函数列表
<a name="RUrg3"></a>
### 监听点击事件的两种方式
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724688937414-78f28727-2bd3-4093-9101-6f47f5c0547f.png#averageHue=%233f3f3f&clientId=uf2696586-d142-4&from=paste&height=124&id=u03d59745&originHeight=186&originWidth=652&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=11938&status=done&style=none&taskId=ub5ee94e1-6958-4ccf-9144-fed1523cd49&title=&width=434.6666666666667)<br />点击事件 是 在按钮区域抬起按下一次 就算一次点击
> 1. 拖脚本
> 2. 代码添加

执行的函数<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724688998050-0087747f-0cff-46db-bed0-6a43dafb2324.png#averageHue=%23aaa9a9&clientId=uf2696586-d142-4&from=paste&height=223&id=u0688b707&originHeight=335&originWidth=429&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=15141&status=done&style=none&taskId=ud26ea68f-58e9-4b2f-9115-514fefbf539&title=&width=286)
```csharp
btn.onClick.AddListener(ClickBtn2);//委托
btn.onClick.AddListener(() => {
    print("123123123");
});
 
btn.onClick.RemoveListener(ClickBtn2);
btn.onClick.RemoveAllListeners();//清空函数
```
<a name="PsPEg"></a>
## Toggle----单选多选框控件
<a name="dlfmi"></a>
### Toggle是什么
Toggle是开关组件<br />是UGUI中用于处理玩家单选框多选框相关交互的关键组件

开关组件 默认是多选框<br />可以通过配合ToggleGroup组件制作为单选框

默认创建的Toggle由4个对象组成<br />父对象-Toggle组件依附<br />子对象--背景图**Backgroud**(必备)、选中图**Checkmark**(必备)、说明文字**Label**(可选)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724690062562-129cb389-1bf1-45f5-97c0-a02d272f0c1c.png#averageHue=%23464646&clientId=uf2696586-d142-4&from=paste&height=102&id=u52fe48f0&originHeight=102&originWidth=222&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=7978&status=done&style=none&taskId=u36e1e89a-5097-4e4a-9655-36a60b68c79&title=&width=222)
<a name="Fc0h3"></a>
### Toggle参数
![红框和button重复](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724690170069-1660e623-b8d6-44f0-b519-2d3dd656e33c.png#averageHue=%234c4c4c&clientId=uf2696586-d142-4&from=paste&height=699&id=u8cbdd1fc&originHeight=699&originWidth=594&originalType=binary&ratio=1.5&rotation=0&showTitle=true&size=61774&status=done&style=none&taskId=u03854124-e793-4fa0-b134-d8693976a94&title=%E7%BA%A2%E6%A1%86%E5%92%8Cbutton%E9%87%8D%E5%A4%8D&width=594 "红框和button重复")
<a name="wzveO"></a>
#### IsOn:当前是否处于打开状态
<a name="TUBhG"></a>
#### Toggle Transition:在开关值变化时的过渡方式
None:无任何过渡，直接显示隐藏<br />Fade:淡入淡出
<a name="Pc7iM"></a>
#### Graphic:用于表示选中状态的图片
一般直接挂着CheckImage
<a name="eZwoc"></a>
#### Group:单选框分组
**要挂载ToggleGroup的脚本**在父组件上面<br />Allow Switch Off:是否允许**不选中**任何一个单选框<br />注意:单选框分组组件可以挂载在**任何对象**上，只需要将其和一组的单选框关联即可
<a name="RU3x8"></a>
##### On Value changed：开关状态变化时执行的函数列表

<a name="UMaAC"></a>
### 代码控制
```csharp
Toggle tog = this.GetComponent<Toggle>();
tog.isOn = true;
print(tog.isOn);

ToggleGroup togGroup = this.GetComponent<ToggleGroup>();
togGroup.allowSwitchOff = false;    //允许开关关闭

//可以遍历提供的迭代器 得到当前处于选中状态的 Toggle
foreach (Toggle item in togGroup.ActiveToggles())
{
    print(item.name + " " + item.isOn);
}
```
<a name="Iegad"></a>
### 监听事件的两种方式

1. 拖脚本
2. 代码添加

![选择上面动态的 不要选下面静态的](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724692006673-c30ae819-a37f-4529-a95c-36348b289ca4.png#averageHue=%23c4c3c2&clientId=uf2696586-d142-4&from=paste&height=467&id=u3f604131&originHeight=701&originWidth=676&originalType=binary&ratio=1.5&rotation=0&showTitle=true&size=51798&status=done&style=none&taskId=uc5b3edd3-4a64-45ac-9290-52c6e0e968f&title=%E9%80%89%E6%8B%A9%E4%B8%8A%E9%9D%A2%E5%8A%A8%E6%80%81%E7%9A%84%20%E4%B8%8D%E8%A6%81%E9%80%89%E4%B8%8B%E9%9D%A2%E9%9D%99%E6%80%81%E7%9A%84&width=450.6666666666667 "选择上面动态的 不要选下面静态的")

```csharp
public void ChangValue(bool isOn)
    {
        print("状态改变" + isOn);
    }    

    private void ChangeValue2(bool v)
    {
        print("代码监听 状态改变2" + v);
    }
```
<a name="BZPx3"></a>
## Inputfield----文本输入控件
<a name="eT5uZ"></a>
### InputField是什么、
InputField是输入字段组件<br />是UGUI中用于处理玩家文本输入相关交互的关键组件

默认创建的 InputField 由3个对象组成<br />父对象-InputField组件依附对象 以及 同时在其上挂载了一个Image作为背景图<br />子对象一文本显示组件(必备)、默认显示文本组件(必备)<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724693504397-d57dc7d2-c689-425e-81fb-32f54f4c8c2d.png#averageHue=%23404b54&clientId=uf2696586-d142-4&from=paste&height=98&id=u57d79d38&originHeight=98&originWidth=321&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=12197&status=done&style=none&taskId=u6be31100-27ee-445d-8b70-371f950f1f6&title=&width=321)
<a name="iZgBZ"></a>
### InputField参数
![和button一样](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724693654138-727b017c-c486-4718-87f2-6b55f6832df1.png#averageHue=%235a5a5a&clientId=uf2696586-d142-4&from=paste&height=381&id=u9954423e&originHeight=381&originWidth=774&originalType=binary&ratio=1.5&rotation=0&showTitle=true&size=39683&status=done&style=none&taskId=u3c3d307a-7f6d-45a4-b8ff-0730cd1f7b8&title=%E5%92%8Cbutton%E4%B8%80%E6%A0%B7&width=774 "和button一样")<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724693667473-8d800c2d-e90e-4809-b932-3c429d23ef17.png#averageHue=%233b3b3b&clientId=uf2696586-d142-4&from=paste&height=893&id=u44c1586b&originHeight=893&originWidth=777&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=64745&status=done&style=none&taskId=uc0899375-0759-41d6-a422-e69db857c0e&title=&width=777)

<a name="ZYJT9"></a>
#### TextComponent：用于关联显示输入内容的文本组件
<a name="J5tUl"></a>
#### Text：输入框的起始默认值
<a name="vac9x"></a>
#### Character Limit：可以输入字符长度的最大值（0为无限）
<a name="ZZvao"></a>
#### Content Type：输入的字符类型限制
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724693830536-f80ddc9e-c493-4cd6-9243-b7b0ac57053f.png#averageHue=%23f2f2f2&clientId=uf2696586-d142-4&from=paste&height=384&id=u6ade0d47&originHeight=576&originWidth=609&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=257709&status=done&style=none&taskId=uec3b0c98-c684-4319-99ac-84c2a1dc41c&title=&width=406)
<a name="CJcXX"></a>
#### Line Type：行类型，定义文本格式
Single Line：只允许单行显示<br />Multi Line Submit：允许使用多行。仅在需要时使用新的一行<br />Multi Line NewLine：允许使用多行。用户可以按回车键空行<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724693978056-1447a0dc-e1ed-4045-8954-2759a3eacc69.png#averageHue=%23959493&clientId=uf2696586-d142-4&from=paste&height=99&id=ue0e1f7fe&originHeight=149&originWidth=461&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=8147&status=done&style=none&taskId=u7ff30b3a-e3e6-46c7-9023-d359e1975dc&title=&width=307.3333333333333)
<a name="VeDYW"></a>
#### Placeholder：关联用于显示初始内容文本控件
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724694150872-9c0d566a-cb82-4d89-8ce6-345f7bd5d376.png#averageHue=%23424c55&clientId=uf2696586-d142-4&from=paste&height=51&id=u9cde8712&originHeight=77&originWidth=261&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=9647&status=done&style=none&taskId=u9136576e-03eb-4898-bdd0-e78b13fc6a9&title=&width=174)
<a name="OHGkU"></a>
#### Caret Blink Rate:光标闪烁速率
<a name="T7T1W"></a>
#### Caret Width:光标宽
<a name="hswGd"></a>
#### Custom Caret Color:自定义光标颜色
<a name="qs4Bj"></a>
#### Selection Color:批量选中的背景颜色
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724694127313-b0147e28-ee2f-490d-ba47-981e593a9f10.png#averageHue=%23eaecea&clientId=uf2696586-d142-4&from=paste&height=65&id=u85dd3c05&originHeight=98&originWidth=323&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=27414&status=done&style=none&taskId=uf075439c-8c75-4b07-bd2e-e63bf413b27&title=&width=215.33333333333334)
<a name="yQByW"></a>
#### Hide Mobile Input:隐藏移动设备屏幕上键盘，仅适用于IOS
<a name="JOo9j"></a>
#### Read Only:只读，不能改
<a name="llbRt"></a>
#### Character Limit:可以输入字符长度的最大值
<a name="d7mrC"></a>
### 代码控制
```csharp
InputField input = this.GetComponent<InputField>();
print(input.text);
input.text = "123123";
```
<a name="SUTDS"></a>
### 监听事件的两种方式
拖脚本
```csharp
public void ChangeInput(string str)
    {
        print("改变的输入内容" + str);
    }

    public void EndInput(string str)
    {
        print("结束输入时内容" + str);
    }
```
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724694437076-268c1a35-fa33-4f50-8694-27ec0a02d0be.png#averageHue=%23404040&clientId=uf2696586-d142-4&from=paste&height=298&id=u0b8854b1&originHeight=447&originWidth=784&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=34132&status=done&style=none&taskId=uef8c3578-423c-40b3-8768-7bba74be884&title=&width=522.6666666666666)
```csharp
代码添加
input.onValueChanged.AddListener((str) =>
{
    print("代码监听 改变" + str);
});

input.onEndEdit.AddListener((str) =>
{
    print("代码监听 结束输入" + str);
});
```
<a name="ZHK1X"></a>
## Slider----滑动条控件
<a name="OLH6q"></a>
### Slider是什么
Slider是滑动条组件<br />是UGUI中用于处理**滑动条相关交互**的关键组件

默认创建的Slider由4组对象组成<br />父对象-Slider组件依附的对象<br />子对象一背景图、进度图、滑动块三组对象<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724694826145-54e91895-ae04-4237-b74d-a55f4aa71927.png#averageHue=%23424242&clientId=uf2696586-d142-4&from=paste&height=117&id=ud0205723&originHeight=176&originWidth=195&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=10506&status=done&style=none&taskId=u7458d614-c661-4f59-9c9f-c15b6dba977&title=&width=130)
<a name="l9q5W"></a>
### slider参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724694880097-b9a78039-626d-4282-a55f-8c7d6645aac9.png#averageHue=%23393939&clientId=uf2696586-d142-4&from=paste&height=279&id=u4e4396a6&originHeight=418&originWidth=800&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=33213&status=done&style=none&taskId=u67433198-7501-41c5-b3a0-87bdd825436&title=&width=533.3333333333334)
<a name="Ce4d6"></a>
#### FilRect：关联用于填充的进度条图形
<a name="n5hXW"></a>
#### Handle Rect：关联用于滑动的滑动块图形
<a name="cBjnI"></a>
#### Direction:滑动条值增加的方向
Left To Right: 从左到右<br />Right To Left: 从右到左<br />Bottom To Top:从下到上<br />Top To Bottom:从上到下
<a name="XJBcp"></a>
#### Min Value 和 Max Value:最小值和最大值，滑动滚动条时值从最小到最大之间变化(左右、上下极值)
<a name="yhXFp"></a>
#### Whole Numbers:是否约束为整数值变化
<a name="DNuOH"></a>
#### Value:当前滑动条代表的数值
<a name="OheRL"></a>
#### OnValueChanged:滑动条值改变时执行的函数列表
<a name="HbesK"></a>
### 代码控制
```csharp
Slider s = this.GetComponent<Slider>();
print(s.value);
```
<a name="SxYjN"></a>
### 监听事件的两种方式
```csharp
s.onValueChanged.AddListener((v) =>
{
    print("代码添加的监听" + v);
});
```
```csharp
public void ChangeValue(float v)
{
    print(v);
}
```
<a name="lban2"></a>
## Scrollbar----滚动条
<a name="NBPtY"></a>
### Scrollbar是什么
Scro11bar是滚动条组件<br />是UGUI中用于处理滚条相关交互的关键组件

默认创建的Scrollbar由2组对象组成<br />父对象-Scrollbar组件依附的对象<br />子对象一滚动块对象<br /> ![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724695789762-3a54f2f1-516f-41fa-9403-22df67f49a0f.png#averageHue=%23414141&clientId=uf2696586-d142-4&from=paste&height=64&id=u65c72117&originHeight=96&originWidth=270&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=6898&status=done&style=none&taskId=u28d380c1-d51e-4988-a3df-dc239dcb42e&title=&width=180)<br />一般情况下我们不会**单独使用滚动条**<br />都是配合ScrollView滚动视图来使用
<a name="dd9FA"></a>
### Scrollbar参数
<a name="PmUbZ"></a>
#### Handle Rect:关联滚动块图形对象
<a name="zmL1y"></a>
#### Direction:滑动条值增加的方向
Left To Right: 从左到右<br />Right To Left:从右到左<br />Bottom To Top:从下到上<br />Top To Bottom:从上到下
<a name="Pe3dY"></a>
#### Value:滚动条初始位置值(0~1)
<a name="Ezph4"></a>
#### Value:滚动块在条中的比例大小(0~1)
<a name="n1Tbe"></a>
#### Number of steps:允许可以滚动多少次(不同滚动位置的数量)
<a name="wGKcC"></a>
#### OnValuechanged:滚动条值改变时执行的函数列表
<a name="SnSRL"></a>
### 代码控制
```csharp
Scrollbar sb = this.GetComponent<Scrollbar>();
print(sb.value);
print(sb.size);
```
<a name="QMQq2"></a>
### 监听事件的两种方式
```csharp
public void ChangeValue(float v)
{
    print(v);
}
```

```csharp
sb.onValueChanged.AddListener((v) => {
    print("代码监听的函数" + v);
});
```
<a name="FJQt9"></a>
## Scrollview----滚动视图
<a name="RN2QL"></a>
### ScrollRect是什么
ScrollRect是滚动视图组件<br />是UGUI中用于处理滚动视图相关交互的关键组件<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724696484728-6d69ccb1-42ce-451a-b349-e29c87544729.png#averageHue=%23424242&clientId=uf2696586-d142-4&from=paste&height=84&id=u9eaffdf7&originHeight=126&originWidth=309&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=9462&status=done&style=none&taskId=u0d939af0-241f-4d63-a60a-b233a49d2ff&title=&width=206)<br />默认创建的scrol1Rect由4组对象组成<br />父对象-scrollRect组件依附的对象 还有一个Image组件 最为背景图<br />子对象<br />Viewport控制滚动视图可视范围和内容显示<br />Scrollbar Horizontal 水平滚动条<br />Scrollbar Vertical 垂直滚动条
<a name="fK8Mz"></a>
### ScrollRect参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724696420555-15e525b7-a3c6-41f3-831b-65be68ebee35.png#averageHue=%233a3a3a&clientId=uf2696586-d142-4&from=paste&height=448&id=uaea24c79&originHeight=672&originWidth=752&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=74567&status=done&style=none&taskId=u43b53a6b-efb1-42fd-a3cb-03075a3aa21&title=&width=501.3333333333333)
<a name="skI1e"></a>
#### Content:控制滚动视图显示内容的父对象，它的尺寸有多大滚动视图就能拖多远
关联的就是下面的 content<br />掌控着总的内容
<a name="VMbTs"></a>
#### Horizontal:启用水平滚动
这两个都可以删除  记得置空
<a name="F4nFs"></a>
#### Vertical:启用垂直滚动
<a name="GBXHA"></a>
#### Movement Type:滚动视图元素的运动类型。主要控制拖动时的反馈效果
Unrestricted(一般不使用):不受限制，随便拖动<br />**Elastic(常用):回弹效果，当滚出边缘后，会弹回边界（系数越大 ）**<br />Elasticity:回弹系数，控制回弹效果。值越大回弹越慢<br />Clamped:夹紧效果，始终限制在范围内，没有回弹效果
<a name="MPhS3"></a>
#### Inertia:移动惯性，如果开启，松开鼠标后会有一定的移动惯性
<a name="etH7e"></a>
#### Deceleration Rate:减速率(0~1)，0没有惯性，1不会停止
<a name="xppfE"></a>
#### Scroll sensitivity:滚轮(鼠标中间)和触摸板(笔记本)的滚动事件敏感性
<a name="NmYJI"></a>
#### Viewport:关联滚动视图内容视口对象
可视范围
<a name="ruYp9"></a>
#### Horizontal Scrollbar:关联水平滚动条
<a name="hAnIa"></a>
#### Visibility:是否在不需要时自动隐藏等模式
Permanent:一直显示滚动条<br />Auto Hide:自动隐藏滚动条<br />Auto Hide And Expand Viewport:自动隐藏滚动条并且自动拓展内容视口
<a name="j8gDV"></a>
#### Spacing:滚动条和视口之间的间隔空间
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724697346364-ca5f17ce-2507-4a11-b552-4c71f0b188db.png#averageHue=%233c3c3c&clientId=uf2696586-d142-4&from=paste&height=51&id=u3199d6fb&originHeight=77&originWidth=698&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=12160&status=done&style=none&taskId=uc4fd3362-549d-4c8d-8ff3-d71c5479651&title=&width=465.3333333333333)<br />这里就是重叠了3个像素
<a name="oFS9D"></a>
#### OnValueChanged:滚动视图位置改变时执行的函数列表

<a name="KnMFI"></a>
### 代码控制
```csharp
ScrollRect sr = this.GetComponent<ScrollRect>();
//改变内容的大小 具体可以拖动多少 都是根据它的尺寸来的
//sr.content.sizeDelta = new Vector2(200, 200);

sr.normalizedPosition = new Vector2(0, 0.5f);
```
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724697701590-d425bdf4-62e8-4abf-951a-0917392d0e94.png#averageHue=%23282726&clientId=uf2696586-d142-4&from=paste&height=69&id=u75ee1a00&originHeight=104&originWidth=451&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=13885&status=done&style=none&taskId=u80c85d49-b598-4b06-827e-e78b74fae97&title=&width=300.6666666666667)
<a name="TYPHH"></a>
### 监听事件的两种方式
```csharp
public void ChangeValue(Vector2 v)
{
    print(v);
}
```

```csharp
sr.onValueChanged.AddListener((vec) =>
{
    print(vec);
});
```
<a name="I7qLT"></a>
## Dropdown----下拉列表控件
<a name="odX7e"></a>
### DropDown是什么
DropDown是下拉列表(下拉选单)组件<br />是UGUI中用于处理下拉列表相关交互的关键组件

默认创建的DropDown由4组对象组成<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724698035977-38bec044-8e26-47c7-80a5-68f96e4a11e6.png#averageHue=%233d3d3d&clientId=uf2696586-d142-4&from=paste&height=83&id=udc6f2b47&originHeight=124&originWidth=351&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=14286&status=done&style=none&taskId=u881c4192-e8ba-4edb-bbc8-bea7b6e8de3&title=&width=234)<br />**父对象**<br />DropDown组件依附的对象 还有一个Image组件 作为背景图

**子对象**<br />Labe1是当前选项描述<br />Arrow右侧小箭头<br />Template下拉列表选单
<a name="lNOAT"></a>
### DropDown参数
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724698145544-48b8698c-2d49-465a-9ac5-851b77d892c9.png#averageHue=%23353535&clientId=uf2696586-d142-4&from=paste&height=444&id=ufb30cbf4&originHeight=666&originWidth=724&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=59255&status=done&style=none&taskId=ud09d4309-686e-441d-8bab-bf8633aa14c&title=&width=482.6666666666667)
<a name="beUc5"></a>
#### Template：关联下拉列表对象
<a name="YFDVR"></a>
#### Caption Text：关联显示当前选择内容的文本组件
<a name="pVCeS"></a>
#### Caption lmage：关联显示当前选择内容的图片组件
<a name="tjUFZ"></a>
#### Item Text：关联下拉列表选项用的文本控件
<a name="JaMPk"></a>
#### ltem lmage：关联下拉列表选项用的图片控件
<a name="BNTSK"></a>
#### Value：当前所选选项的索引值
<a name="UlrLg"></a>
#### Alpha Fada speed：下拉列表窗口淡入淡出的速度
<a name="s1AWp"></a>
#### Options：存在的选项列表
第一个是0<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724777985978-8cc72b4c-09aa-4c39-81d8-ada6295f99c7.png#averageHue=%23b3afad&clientId=u16a5364b-648d-4&from=paste&height=285&id=u0be42953&originHeight=428&originWidth=695&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=21281&status=done&style=none&taskId=uc8b6a478-238b-4e32-a953-ccd0b836f95&title=&width=463.3333333333333)
<a name="IoxCF"></a>
### 代码控制
```csharp
Dropdown dd = this.GetComponent<Dropdown>();

print(dd.value);

print(dd.options[dd.value].text);//索引器

dd.options.Add(new Dropdown.OptionData("123123123"));
```
<a name="yUdKw"></a>
### 监听事件的两种方式
```csharp
public void ChangeValue(int value)
{
    print(value);
}
```
```csharp
dd.onValueChanged.AddListener((index) => {

    print(index);
});
```
<a name="POenH"></a>
# 图集制作
<a name="OlhAY"></a>
## 为什么要打图集
UGUI和NGUI使用上最大的不同是 NGUI使用前就要打图集<br />UGuI可以再之后再打图集

打图集的目的就是减少**Drawcall ** 提高性能<br />具体Drawcall是什么在NGUI课程中已经详细讲解

简单回顾DrawCall<br />**Dc就是COU通知GPU进行一次渲染的命令**<br />如果Dc次数较多会导致游戏卡顿<br />我们可以通过打图集，将小图合并成大图，将本应n次的Dc变成1次Dc来提高性能
<a name="mOyB1"></a>
## 在unity中打开自带的打图集功能
在工程设置面板中打开功能<br />Edit->Project Setting->Editor![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724778840999-bbbbc3e5-bf59-49cd-8c17-839ea93168c1.png#averageHue=%23464646&clientId=u16a5364b-648d-4&from=paste&height=541&id=u1a5e3ba4&originHeight=812&originWidth=1618&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=155337&status=done&style=none&taskId=u163c9639-abd7-4099-be56-1660901d5f6&title=&width=1078.6666666666667)
<a name="V4t2S"></a>
### Sprite packer
(精灵包装器，可以通过unity自带图集工具生成图集)
<a name="MvjM2"></a>
#### Disabled:
默认设置，不会打包图集
<a name="PbddR"></a>
#### Enabled For Builds(Legacy sprite Packer):
unity仪在构建时打包图集，在编辑模式下**不会打包图集**
<a name="uGm5w"></a>
#### Always Enabled(Legacy sprite Packer):
Unity在构建时打包图集，在编辑模式下运行前**会打包图集**<br />**(一般选这个)**
<a name="m6r7R"></a>
#### Legacy Sprite Packer( V2 )
传统打包模式 相对下面两种模式来说 多了一个设置图片之间的间隔距离

<a name="VrqxO"></a>
### Padding Power  
:选择打包算法在计算打包的精灵之间以及精灵与生成的图集边缘之间的间隔距离<br />这里的数字 代表2的n次方<br />~~不知道移到哪里去了....~~
<a name="oUqhN"></a>
## 打图集参数注意

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724779252889-d3a1584f-078a-4e4b-8363-4a8b1a9f654e.png#averageHue=%23e9e8e7&clientId=u16a5364b-648d-4&from=paste&height=273&id=VE5My&originHeight=409&originWidth=774&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=30109&status=done&style=none&taskId=u20cc9e12-1604-42b3-9818-941b825e40b&title=&width=516)

这个路径创建图集<br />在UGUI要取消勾选**旋转** Allow Rotation 和 **扩出边缘轮廓** Tight Packing<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724779330893-86b8ad13-6ccf-4a11-b084-1ea681171f0c.png#averageHue=%233d3d3d&clientId=u16a5364b-648d-4&from=paste&height=63&id=KMRvS&originHeight=94&originWidth=354&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=7094&status=done&style=none&taskId=u0c01c33f-a297-4899-a7aa-264340c5062&title=&width=236)

在一个图集中间插入其他图片 会打断图集批处理
<a name="pjiq5"></a>
## 代码加载
```csharp
//加载图集 
SpriteAtlas sa = Resources.Load<SpriteAtlas>("MyAlas");
//需要引用命名空间  using UnityEngine.U2D;

//从图集中加载指定名字的小图
sa.GetSprite("bk");
```






<a name="z1VCs"></a>
# Ui事件监听接口
<a name="GGvjv"></a>
### 事件接口是用来解决什么问题的
目前所有的控件都只提供了常用的事件监听列表<br />如果想做一些类似长按，双击，拖拽等功能是无法制作的<br />或者想让Image和Text，RawImage三大基础控件能够响应玩家输入也是无法制作的

而事件接口就是用来处理类似问题<br />让所有控件都能**够添加更多的事件监听**来处理对应的逻辑
<a name="KtCC0"></a>
### 有哪些事件接口
<a name="GS5Gg"></a>
#### 常用事件接口
**IPointerEnterHandler - OnPointerEnter** - 当指针进入对象时调用 (鼠标进入)<br /> <br />**IPointerExitHandler - OnPointerExit** - 当指针退出对象时调用 (鼠标离开)

**IPointerDownHandler - OnPointerDown** - 在对象上按下指针时调用(按下)(抬起)

**IPointerUpHandler - OnPointerup** - 松开指针时调用(在指针正在点击的游戏对象上调用)

**IPointerclickHandler - OnPointerclick **- 在同一对象上按下再松开指针时调用 (点击)

**IBeginDragHandler -  OnBeginDrag **- 即将开始拖动时在拖动对象上调用(开始拖拽)

**IDragHandler - OnDrag -** 发生拖动时在拖动对象上调用(拖中)

**IEndDragHandler - OnEndDrag** - 拖动完成时在拖动对象上调用(结束拖拽)
<a name="LOik6"></a>
#### 不常用事件接口 了解即可
IInitializePotentialDragHandler - OnInitializePotentialDrag<br /> 在找到拖动目标时调用 可用于初始化值

IDropHandler - OnDrop<br />在拖动目标对象上调用<br />IScrollHandler - Onscroll<br />当鼠标滚轮滚动时调用<br />IUpdateselectedHandler - OnUpdateselected<br />每次勾选时在选定对象上调用

ISelectHandler - Onselect<br />当对象成为选定对象时调用<br />IDeselectHandler - OnDeselect<br />取消选择选定对象时调用

导航相关<br />IMoveHandler - OnMove <br />发生移动事件(上、下、左、右等)时调用

ISubmitHandler - Onsubmit<br />按下 submit 按钮时调用

ICancelHandler - Oncancel<br />按下Cancel按钮时调用
<a name="mpBfS"></a>
### 使用事件接口
实现接口中的内容<br />继承Monoaehavior的脚本继承对应的事件接口，引用命名空间<br />将该脚本挂载到想要监听自定义事件的UI控件上

**接口可以继承无数个  接口必须实现**
<a name="AdMHA"></a>
### PointerEventData参数的关键内容
父类:**BaseEventData**<br />**pointerId:** 鼠标左右中键点击鼠标的ID 通过它可以判断石键点击<br />**position**:当前指针位置(屏幕坐标系)<br />**pressPasition**:按下的时候指针的位置<br />**delta**:指针移动增量<br />**olickcount:**连击次数<br />**elickTime:**点击时间

<a name="LgZvH"></a>
# Eventtrigger事件触发器
<a name="YdgLl"></a>
## 事件触发器是什么
事件触发器是**EventTrigger组件**<br />它是一个集成了上节课中学习的**所有事件接口的脚本**<br />它可以让我们更方便的为控件添加事件监听<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724783027388-26e7242e-4984-4a60-99d9-7187917863e8.png#averageHue=%23a5a4a4&clientId=u34fa0720-7670-4&from=paste&height=437&id=u2253c4db&originHeight=655&originWidth=521&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=42210&status=done&style=none&taskId=u4ea4036c-f881-4e97-b1b1-2b11c10389f&title=&width=347.3333333333333)
<a name="qAaJ2"></a>
## 如何使用事件触发器
<a name="qbfGU"></a>
### 拖曳脚本进行关联
```csharp
public void TestPointerEnter( BaseEventData data )//引用命名空间 using UnityEngine.EventSystems;
    {
        //传的是一个基类
        PointerEventData eventData = data as PointerEventData;

        print("鼠标进入 " + eventData.position);
    }
```
<a name="ksczX"></a>
### 代码添加
![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724863591689-53d32c6a-0cc5-4a7b-a0bc-b1f647d53f3f.png#averageHue=%233a3a3a&clientId=u8f5fb5ff-d24d-4&from=paste&height=170&id=u74fa3d41&originHeight=170&originWidth=842&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=19662&status=done&style=none&taskId=u348e4226-d637-4827-9660-a3ff4b0b795&title=&width=842)<br />**EventTrigger 需要拖对象  否则会报错！！**

每次加一个事件监听 都要new一个函数
```csharp
申明一个希望监听的事件对象
EventTrigger.Entry entry = new EventTrigger.Entry();
//申明 事件的类型
entry.eventID = EventTriggerType.Drag;
//监听函数关联
entry.callback.AddListener((data) =>
{
    print("抬起");
});





//把申明好的 事件对象 加入到 EventTrigger当中
et.triggers.Add(entry);

entry = new EventTrigger.Entry();
entry.eventID = EventTriggerType.BeginDrag;
entry.callback.AddListener((data) =>
{
    print("抬起");
});
et.triggers.Add(entry);

entry = new EventTrigger.Entry();
entry.eventID = EventTriggerType.BeginDrag;
entry.callback.AddListener((data) =>
{
    print("抬起");
});
et.triggers.Add(entry);


//可以有一样的操作 也可以遍历去找
//不会报错
```
<a name="JwLPd"></a>
# 屏幕坐标转Ui相对坐标
<a name="Xu6Vt"></a>
## RectTransformUtility类
RectTransformutility 公共类是-个RectTransform的辅助类<br />主要用于进行一些 坐标的转换等等操作<br />其中对于我们目前来说 **最重要的函数是 将屏幕空间上的点，转换成UI本地坐标下的点**
<a name="PxGY2"></a>
## 将屏幕坐标转换为UI本地坐标系下的点
方法<br />RectTransformUtility.ScreenPointToLocalPointInRectangle<br />参数一：相对父对象<br />参数二：屏幕点<br />参数三：摄像机<br />参数四：最终得到的点<br />一般配合拖拽事件使用

```csharp
Vector2 nowPos;
RectTransformUtility.ScreenPointToLocalPointInRectangle(
    parent,
    eventData.position,
    eventData.enterEventCamera,
    out nowPos );

//使用this.parent可以无论父对象是谁 会自动获取
//不恰当的父对象会偏移（效果不好）

this.transform.localPosition = nowPos;
```
<a name="lvX1T"></a>
# Mask遮罩
<a name="eeSBF"></a>
## 遮罩是什么
在不改变图片的情况下I<br />让图片在游戏中只显示其中的一部分
<a name="QKxK6"></a>
## 遮罩如何使用
Scroll View中使用到了这个脚本<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724865879302-5fd75862-95bc-402e-841e-d1bf17d9bb23.png#averageHue=%233d3d3d&clientId=u8f5fb5ff-d24d-4&from=paste&height=136&id=u66928c39&originHeight=204&originWidth=616&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=23530&status=done&style=none&taskId=u6a64cb18-2777-4485-a5e3-793272b8764&title=&width=410.6666666666667)

实现遮罩效果的关键组件时Mask组件<br />通过在**父对象上系Mask组件即可遮罩其子对象**<br />注意:

1. 想要被遮罩的Image需要勾选Maskable
2. 只要父对象添加了Mask组件，那么**所有的UI子对象都会被遮罩**
3. 遮罩父对象图片的制作，不透明的地方显示，透明的地方被遮罩

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724866430793-e4c8757a-f12c-4f3b-adcd-1474070b6e9e.png#averageHue=%236e6965&clientId=u8f5fb5ff-d24d-4&from=paste&height=280&id=uf13d6744&originHeight=420&originWidth=448&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=27089&status=done&style=none&taskId=u3f585f8c-fb97-47d1-ae70-cf81a7c98a8&title=&width=298.6666666666667)
<a name="eh5s3"></a>
# 模型和粒子显示在Ui之前
<a name="QNOE1"></a>
## 模型显示在UI之前
<a name="npnoz"></a>
### 直接用摄像机渲染3D物体
canvas的渲染模式要不是覆盖模式<br />摄像机模式 和 世界(3D)模式都可以让模型显示在UI之前(z轴在UI元素之前即可)

注意:<br />1.摄像机模式时建议用**专门的摄像机**渲染UI相关<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724866621975-f79a3574-44df-4c6f-9be6-bf036de71254.png#averageHue=%233e3e3e&clientId=u8f5fb5ff-d24d-4&from=paste&height=461&id=udac95cf1&originHeight=692&originWidth=601&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=72005&status=done&style=none&taskId=u695d8b7f-1c4f-4b7c-aa5b-6f73fd7b7bb&title=&width=400.6666666666667)<br />同时移去主摄像机的UI层渲染<br />2.面板上的3D物体建议也用UI摄像机进行渲染
<a name="YgBOD"></a>
### 将3D物体渲染在图片上，通过图片显示
专门使用一个摄像机渲染3D模型，将其渲染内容输出到**Render Texture**上<br />类似小地图的制作方式<br />再将渲染的图显示在UI上

该方式  **不管Canvas的渲染模式是哪种都可以使用 （比较少）**
<a name="HNb5p"></a>
## 粒子特效显示在UI之前
粒子特效的显示和3D物体类似

注意点:<br />在摄像机模式下时<br />可以在**粒子组件的Renderer相关参数中改变排序层** 让粒子特效始终显示在其之前不受z轴影响
<a name="F2PZX"></a>
# 异形按钮
<a name="paL9K"></a>
## 什么是异形按钮
图片形状不是传统矩形的按钮
<a name="mB7O6"></a>
## 如何让异形按钮能够准确点击
<a name="NmeRN"></a>
### 通过添加子对象的形式
按钮之所以能够响应点击，主要是根据图片矩形范围进行判断的<br />它的范围判断是**自下而上的**，意思是如果有子对象图片，**子对象图片的范围也会算为可点击范围**<br />那么我们就可以用多个透明图拼凑不规则图形作为按钮子对象用于进行射线检测<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724868734054-feb513f9-011b-4101-8b6a-d0d078ce02cc.png#averageHue=%23d8e9d5&clientId=u8f5fb5ff-d24d-4&from=paste&height=404&id=u2c0acb7e&originHeight=404&originWidth=615&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=142426&status=done&style=none&taskId=u71aa2be8-fd78-4fe2-8f0a-d60a566d217&title=&width=615)
<a name="Lcujz"></a>
### 通过代码改变图片的透明度响应阈值
对内存消耗大

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724868814113-d212475a-ca91-489d-95fa-3aff0c01ea4e.png#averageHue=%233f3f3f&clientId=u8f5fb5ff-d24d-4&from=paste&height=246&id=ua0be78a4&originHeight=246&originWidth=626&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=27007&status=done&style=none&taskId=uf288fb4c-fc0c-4f65-8c74-35d7bd4adb8&title=&width=626)<br />第一步:修改图片参数 **开启Read/write Enabled开关**<br />第二步:通过代码修改图片的响应阈值<br />该参数含义:指定一个像素必须具有的最小alpha值，以变能够认为射线命中了图片<br />说人话:当像素点alpha值小于 该值 就不会被射线检测了

```csharp
img.alphaHitTestMinimumThreshold = 0.1f;
```
<a name="K0OPO"></a>
# 自动布局组件
<a name="gWxVX"></a>
## 自动布局是什么
虽然uGuI的RectTransform已经非常方便的可以帮助我们快速布局<br />但UGUI中还提供了很多可以帮助我们对UI控件进行自劫布局的组件<br />他们可以帮助我们自动的设置UI控件的位置和大小等

自动布局的工作方式一般是<br />**自动布局控制组件 + 布局元素 = 自动布局**

自动布局控制组件：unity提供了很多用于自动布局的管理性质的组件用于布局<br />布局元素：具备布局属性的对象们，这里主要是指具备RectTransform的UI组件
<a name="wRXOg"></a>
## 布局元素的布局属性
要参与自动布局的布局元素必须包布局属性<br />![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724869389437-3b6c079f-f768-4751-9e23-91c7eafe6109.png#averageHue=%23373737&clientId=u8f5fb5ff-d24d-4&from=paste&height=217&id=u04dce0c2&originHeight=325&originWidth=647&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=30293&status=done&style=none&taskId=ucd488aa0-fb92-4ec7-a470-69ea7f1e26f&title=&width=431.3333333333333)<br />布局属性主要有以下几条<br />**Minmum width:**该布局元素应具有的最小宽度<br />**Minmum height:**该布局元素应具有的最小高度

**Preferred width**:在分配额外可用宽度之前，此布局元素应具有的宽度<br />**Preferred height:**在分配额外可用高度之前，此布局元素应具有的高度

**Flexible width:**此布局元素应相对于其同级而填充的额外可用宽度的相对量<br />**Flexible height:**此布局元素应相对于其同级而填充的额外可用高度的相对量

在进行自动布局时 都会通过计算布局元素中的这6个属性得到控件的大小位置

在布局时，布局元素大小设置的基本规则是

1. 首先分配最小大小**Minmum width**和**Minmum height**
2. 如果父类容器中有足够的可用空间，则分配**Preferred width**和**Preferred height**
3. 如果上面两条分配完成后还有额外空间，则分配**Flexible width**和**Flexible height**

一般情况下布局元素的这些属性都是0<br />但是特定的UI组件依附的对象布局属性会被改变，比如Image和Text

一般情况下我们不会去手动修改他们，但是如果你有这些需求<br />可以手动添加一个**LayoutElemen**t组件 可以修改这些布局属性

<a name="gSgwH"></a>
## 水平垂直布局组件
水平垂直布局组件<br />将子对象并排或者竖直的放在一起

组件名:**Horizontal Layout Group**和**Vertical Layout Group**<br />参数相关:<br />Padding:左右上下边缘偏移位置<br />Spacing:子对象之间的间距

**ChildAlignment:**九宫格对其方式<br />Control child size:是否控制子对象的宽高<br />Use child sca1e:在设置子对象大小和布局时，是否考虑子对象的缩放<br />Child Force Expand:是否强制子对象拓展以填充额外可用空间
<a name="QUy5Z"></a>
## 网格布局组件
网格布局组件<br />将子对象当成一个个的格子设置他们的大小和位置

组件名:Grid Layout Group<br />参数相关:<br />Padding:左右上下边缘偏移位置<br />Cel1 size:每个格子的大小<br />Spacing:格子间隔<br />start corner:第一个元素所在位置(4个角)<br />start Axis:沿哪个轴放置元素:Horizontal水平放置满换行，Vertical竖直放置满换列<br />child Alignment:格子对其方式(9宫格)<br />constraint:行列约束<br />Flexible:灵活模式，根据容器大小自动适应<br />Fixed Column Count:固定列数<br />Fixed Row count:固定行数
<a name="Kf0Tr"></a>
## 内容大小适配器
内容大小适配器<br />它可以自动的调整RectTransform的长宽来让组件自动设置大小<br />般在Text上使用 或者 配合其它布局组件于起使用

组件名:Content size Fitter<br />参数相关<br />Horizontal Fit:如何控制宽度<br />Vertical Fit:如何控制高度

Unconstrained:不根据布局元素伸展<br />Min size:根据布局元素的最小宽高度来伸展<br />Preferred size:根据布局元素的偏好宽度来伸展宽度,
<a name="EdEZ2"></a>
## 宽高比适配器（了解）
宽高比适配器<br />1.让布局元素按照一定比例来调整自己的大小<br />2.使布局元素在父对象内部根据父对象大小进行适配

组件名:Aspect Ratio Fitter<br />参数相关:<br />Aspect Mode:适配模式，如果调整矩形大小来实施宽高比<br />None:不让矩形适应宽高比<br />width controls Height:根据宽度自动调整高度<br />Height controls width:根据高度自动调整宽度<br />Fit In Parent:自动调整宽度、高度、位置和锚点，使矩形适应父项的矩形，同时保持宽高比，会出现“黑边”<br />Envelope Parent:自动调整宽度、高度、位置和锚点，使矩形覆盖父项的整个区域，同时保持宽高比，会出现“裁剪”

Aspect Ratio:宽高比:宽除以高的比值
<a name="Lfh0K"></a>
# Canvas Group整体控制
**问题:如何整体控制一个面板的淡入淡出等**<br />如果我们想要整体控制一个面板的淡入淡出 或者 整体禁用<br />使用目前学习的知识点 是无法方便快捷的设置的


**解决方案:Canvas Group**<br />为面板父对象添加 canvasGroup组件 即可整体控制

参数相关:<br />Alpha:整体透明度控制<br />Interactable:整体启用禁用设置<br />Blocks Raycasts:整体射线检测设置<br />Ignore Parent Groups:是否忽略父级canvasGroup的作用

<a name="cGFIA"></a>
# 总结
UGUI的源代码是能被直接看到的<br />Unity安装目录下<br />**DataResources\PackageManager\BuiltlnPackages\com.unity.ugui**<br />随着自己的能力提升<br />以后可以深入去了解一下它的一些逻辑实现


每一个控件的代码相关我只讲了重要的<br />可以通过控件对象点出它的所有公共成员进行使用和设置

![image.png](https://cdn.nlark.com/yuque/0/2024/png/42440971/1724872667424-5e217d90-9999-4395-b1fe-b11cd35a2528.png#averageHue=%23f3f3f3&clientId=u09e5a39d-d9d6-4&from=paste&height=245&id=u13a02997&originHeight=368&originWidth=855&originalType=binary&ratio=1.5&rotation=0&showTitle=false&size=80941&status=done&style=none&taskId=u940dcff5-be65-428f-b350-a03b2bafd7e&title=&width=570)








