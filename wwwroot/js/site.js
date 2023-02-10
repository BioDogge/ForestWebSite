window.addEventListener("scroll", e => {
    document.body.style.cssText += `--scrollTop: ${this.scrollY}px`
})

gsap.registerPlugin(ScrollTrigger, ScrollSmoother);
gsap.config({ trialWarn: false });

ScrollSmoother.create({
    wrapper: '.wrapper',
    content: '.container'
})