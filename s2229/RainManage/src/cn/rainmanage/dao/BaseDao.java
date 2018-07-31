package cn.rainmanage.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import javax.naming.Context;
import javax.naming.InitialContext;
import javax.sql.DataSource;

public class BaseDao {
	// 1.four connetion property 四大连接属性
	public static final String driver = "com.mysql.jdbc.Driver";
	public static final String url = "jdbc:mysql:///rain";
	public static final String username = "root1";
	public static final String password = "0216";
	/*
	 * public static final String url="jdbc:mysql:///easybuy"; public static
	 * final String username="root"; public static final String password="root";
	 */

	// 1.2 三大接口
	Connection con;// 负责打通和数据库的连接
	PreparedStatement ps; // 可以向Server发送SQL指令
	ResultSet rs; // 和DB建立了一个实时的读取数据的工具

	// 2.get connection method 获取连接的方法
	public Connection getConnection() throws Exception {
		Class.forName(driver);
		if (con == null || con.isClosed()) {
			con = DriverManager.getConnection(url, username, password);
		}
		return con;
	}

	public Connection getConnectionold() throws Exception {
		Context ctxContext = new InitialContext();
		DataSource dSource = (DataSource) ctxContext
				.lookup("java:comp/env/jdbc/easybuy_user");
		if (con == null || con.isClosed()) {
			con = dSource.getConnection();
		}
		return con;
	}

	// 3.close all resource 关闭资源的方法
	public void closeAllResources() throws Exception {
		// alt+上下箭头，调整code位置
		if (rs != null) {
			rs.close();
		}
		if (ps != null) {
			ps.close();
		}
		if (con != null) {
			con.close();
		}
	}

	// 4. execute update delte and insert method return must be a int type ,it
	// means affect rows
	/**
	 * 
	 * @param sql
	 *            将要执行的sql
	 * @param objs
	 *            可变参数 ，从界面上传递过来的参数个数不确定 Object... objs
	 * @return 受影响行数 只能执行 CUD(create update delete)
	 * @throws Exception
	 *             预判到和DB的交互，可能会有一场，所以我们预先声明了顶级异常
	 */
	public int executeUpdate(String sql, Object... objs) throws Exception {
		getConnection();
		ps = con.prepareStatement(sql);
		for (int i = 0; i < objs.length; i++) {
			ps.setObject(i + 1, objs[i]);
		}
		int count = ps.executeUpdate();
		return count;
	}

	// 5. execute select method
	/**
	 * 
	 * @param sql
	 *            将要执行的sql
	 * @param objs
	 *            可变参数 ，从界面上传递过来的参数个数不确定 Object... objs
	 * @return 受影响行数 只能执行 CUD(create update delete)
	 * @throws Exception
	 *             预判到和DB的交互，可能会有一场，所以我们预先声明了顶级异常
	 */
	public ResultSet executeQuery(String sql, Object... objs) throws Exception {
		getConnection();
		ps = con.prepareStatement(sql);
		for (int i = 0; i < objs.length; i++) {
			ps.setObject(i + 1, objs[i]);
		}
		rs = ps.executeQuery();
		return rs;
	}

}
