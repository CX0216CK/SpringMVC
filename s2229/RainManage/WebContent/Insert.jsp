<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<script type="text/javascript" src="jquery-1.8.3.min (1).js">
</script>
<script type="text/javascript">

	function save() {
	
	 var username=$("#username").val();
	 var phone=$("#phone").val();
	 var email=$("#email").val();
	 var ss=$("#ss").val();
	 var match =/^[+-]?\d*\.?\d*$/;
	 var zahn=$("#zahn").val();
	 if(username==""){
		 alert("区域名称不能为空")
		 return;
	 }else if(phone==""){
		 alert("检测时间不能为空")
		 return;
	 }else if(email==""){
		 alert("雨量值不能为空")
		 return;
	 }
	 else if(!match.test(email)){
		 alert("雨量值只能为数字")
		 return;
	 }
	 else if(ss==""){
		 alert("检测站不能为空")
		 return;
	 }
	 else if(zahn==""){
		 alert("地址不能为空")
		 return;
	 }
		location.href="/RainManage/RainManageSerclet?oper=insert&&username="+username+"&&phone="+phone+"&&email="+email+"&&ss="+ss+"&&zahn="+zahn;
	}
</script>
<body>
<table border="1">
   
    <tr>
        <th>区域名称</th>
        <td><input value=" " id="username"></td>
      
    </tr>
    <tr>
        <th>检测时间</th>
        <td><input value=" " id="phone"></td>
        
    </tr>
     <tr>
        <th>雨量值</th>
        <td><input value=" " id="email"></td>
       
    </tr>
       <tr>
        <th>检测站</th>
        <td> <input value=" " id="ss"> </td>
        </tr>
        <tr>
         <th>地址</th>
        <td> <input value=" " id="zahn"> </td>
        </tr>
<tr><td><button onclick="save()">提交</button></td></tr>
        
    
</table>
</body>
</html>