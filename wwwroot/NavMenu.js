document.addEventListener("DOMContentLoaded", function () {
    const navbar = document.querySelector(".navbar");

    if (navbar) {
        let lastScrollTop = 0;

        // Function to show or hide the navbar
        function handleScroll() {
            const mainLayout = document.querySelector("main");
            const currentScrollTop = mainLayout.scrollTop;

            if (currentScrollTop > lastScrollTop) {
                // Scrolling down: hide the navbar
                navbar.style.transform = `translateY(-${navbar.offsetHeight / 2}px)`;
            } else {
                // Scrolling up: show the navbar
                navbar.style.transform = "translateY(0)";
            }

            lastScrollTop = currentScrollTop <= 0 ? 0 : currentScrollTop;
        }

        // Listen for scroll events
        document.querySelector("main").addEventListener("scroll", handleScroll);
        
        // Adjust margin on window resize if needed
        window.addEventListener("resize", () => {
            const navbarHeight = navbar.offsetHeight;
            mainElement.style.marginTop =
                navbar.style.transform === "translateY(0)" ? `${navbarHeight / 2}px` : "0";
        });
    }
});