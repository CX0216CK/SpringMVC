<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
<script type="text/javascript" src="jquery-1.8.3.min (1).js">

</script>
<script type="text/javascript">

$(function(){
	$("tr:even").css("background","pink")
})
function del(id,obj){
	if(confirm("确认删除吗")){
	$.ajax({
		"url" : "RainManageSerclet", //要提交的URL路径
		"type" : "post", //发送请求的方式
		"data" : {
			"oper" : "del",
			"id" : id,
		}, //要发送到服务器的数据
		"dataType" : "text", //指定返回的数据格式
		"success" : callBack, //响应成功后要执行的代码
		"error" : function() { //请求失败后要执行的代码
		}
	});
	}
	function callBack(dom) {
	
		 $("#"+id+"").parent().empty();
	}
}

</script>
</head>
<body>
<table border="1" id="tblMain">
<tr>
<th>序号</th>
<th>区域名称</th>
<th>检测时间</th>
<th>雨量值</th>
<th>监测站</th>
<th>站点地址</th>
<th>操作</th>
</tr>

<c:forEach items="${findall }" var="all">
<tr >
<td>${all.id }</td>
<td>${all.districtName }</td>
<td>${all.monitorTime }</td>
<td>${all.rain }</td>
<td>${all.monitoringStation }</td>
<td>${all.monitoringAddress }</td>
<td id="${all.id }"><a href="javascript:void(0)" onclick="del(${all.id },'this')">删除</a></td>

</tr>
</c:forEach>

</table>
<div><a href="/RainManage/Insert.jsp">新增</a></div>

</body>
</html>