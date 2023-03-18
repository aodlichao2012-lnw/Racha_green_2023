function act1(){
    document.querySelector('.sidebar-item3').classList.add('active');
}

function getnav() {
  const htmls = "<ul class='menu'>"+
    "<li class='sidebar-title'>Menu</li>"+

    "<li class='sidebar-item1'>"+
        "<a href='index.html' class='sidebar-link'>"+
            "<i class='bi bi-grid-fill'></i>"+
            "<span>Dashboard</span>"+
        "</a>"+
    "</li>"+
    "<li class=' sidebar-item2'>"+
        "<a href='Index2.html' class='sidebar-link'>"+
           " <i class=' bi bi-grid-fill'></i>"+
            "<span>วิสัยทัศน์โรงเรียน</span>"+
        "</a>"+
    "</li>"+    

    "<li class=' sidebar-item3'>"+
        "<a href='component-card.html' class='sidebar-link'>"+
            "<i class=' bi bi-grid-fill'></i>"+
            "<span>ทำเนียบรุ่น</span>"+
        "</a>"+
    "</li>"+    
    "<li class=' sidebar-item4'>"+
        "<a href='#' class='sidebar-link'>"+
            "<i class=' bi bi-grid-fill'></i>"+
            "<span>ติดต่อบุคลากร</span>"+
        "</a>"+
    "</li>"+  
    "<li class=' sidebar-item5'>"+
        "<a href='index3.html' class='sidebar-link'>"+
            "<i class=' bi bi-grid-fill'></i>"+
            "<span>ประวัติของโรงเรียน</span>"+
        "</a>"+
    "</li>"+  
    "<li class=' sidebar-item6'>"+
        "<a href='auth-login.html' class='sidebar-link'>"+
            "<i class=' bi bi-grid-fill'></i>"+
            "<span>เข้าสู่ระบบ</span>"+
        "</a>"+
    "</li>"+  
    "<li class='sidebar-item  '>"+
        "<a href='https://github.com/zuramai/mazer#donate' class='sidebar-link'>"+
            "<i class='bi bi-cash'></i>"+
            "<span>Donate</span>"+
        "</a>"+
    "</li>"+
"</ul>"

 document.querySelector("#nav_main45").innerHTML = htmls
}
window.onload = getnav();
