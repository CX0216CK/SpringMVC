package cn.rainmanage.servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import cn.rainmanage.entity.RainManage;
import cn.rainmanage.service.IRainManageservice;
import cn.rainmanage.service.impl.IRainManageserviceImpl;

/**
 * Servlet implementation class RainManageSerclet
 */
@WebServlet("/RainManageSerclet")
public class RainManageSerclet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	IRainManageservice irain = new IRainManageserviceImpl();

	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		String oper = request.getParameter("oper");
		if ("del".equals(oper)) {
			try {
				delete(request, response);
				return;
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		if ("insert".equals(oper)) {
			try {
				insert(request, response);
				return;
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		try {
			list(request, response);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// 新增
	private void insert(HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		String districtName = request.getParameter("username");
		String monitorTime = request.getParameter("phone");
		String rain = request.getParameter("email");
		String monitoringStation = request.getParameter("ss");
		String monitoringAddress = request.getParameter("zahn");
		RainManage rainManage = new RainManage();
		rainManage.setDistrictName(districtName.trim());
		rainManage.setMonitoringAddress(monitoringAddress.trim());
		rainManage.setMonitoringStation(monitoringStation.trim());
		rainManage.setMonitorTime(monitorTime.trim());
		rainManage.setRain(Integer.valueOf(rain.trim()));
		irain.insert(rainManage);
		response.sendRedirect("/RainManage/RainManageSerclet");
	}

	// 列表
	public void list(HttpServletRequest request, HttpServletResponse response)
			throws Exception {
		List<RainManage> findall = irain.findall();
		request.setAttribute("findall", findall);
		request.getRequestDispatcher("/Index.jsp").forward(request, response);
	}

	// 删除
	public void delete(HttpServletRequest request, HttpServletResponse response)
			throws NumberFormatException, Exception {
		String id = request.getParameter("id");
		int delete = irain.delete(Integer.valueOf(id));
		if (delete > 0) {
			response.getWriter().write("true");
		}
	}
}
