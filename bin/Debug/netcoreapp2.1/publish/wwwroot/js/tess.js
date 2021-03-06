class DocumentView {
    constructor(page) {
        this.page = page;
        this.drawOverlay = () => {
            this.overlayCanvas.width = this.docImage.width;
            this.overlayCanvas.height = this.docImage.height;
            this.overlayCtx.clearRect(0, 0, this.overlayCanvas.width, this.overlayCanvas.height);
            // draw boxes.
            for (let b of this.page.blocks) {
                if (this.showBlocks) {
                    this.overlayCtx.strokeStyle = "rgba(255, 0, 180, 0.8)";
                    this.overlayCtx.strokeRect(b.rect.left - 6, b.rect.top - 6, b.rect.width + 12, b.rect.height + 12);
                }
                for (let p of b.paragraphs) {
                    if (this.showParagraphs) {
                        this.overlayCtx.strokeStyle = "rgba(0, 120, 255, 0.8)";
                        this.overlayCtx.strokeRect(p.rect.left - 4, p.rect.top - 4, p.rect.width + 8, p.rect.height + 8);
                    }
                    for (let l of p.lines) {
                        if (this.showLines) {
                            this.overlayCtx.strokeStyle = "rgba(255, 80, 0, 0.8)";
                            this.overlayCtx.strokeRect(l.rect.left - 2, l.rect.top - 2, l.rect.width + 4, l.rect.height + 4);
                        }
                        if (this.showWords) {
                            for (let w of l.words) {
                                if (w.rect.height < this.docCanvas.height * 0.95) {
                                    this.overlayCtx.fillStyle = this.confidenceToStyle(w.confidence);
                                    this.overlayCtx.fillRect(w.rect.left, w.rect.top, w.rect.width, w.rect.height);
                                }
                                else {
                                    l.words = l.words.filter((item) => item !== w);
                                }
                            }
                        }
                    }
                }
            }
        };
        this.moveHoverDiv = (x, y) => {
            this.hoverDiv.hidden = false;
            this.hoverDiv.innerHTML = `<span>Text: ${this.escapeHtml(this.hoverBox.text)}</span><br/><span>Confidence: ${this.hoverBox.confidence}%</span>`;
            if (x > document.documentElement.clientWidth - 200) {
                x = x - 200;
            }
            if (y > document.documentElement.clientHeight - 100) {
                y = y - 100;
            }
            this.hoverDiv.style.left = (x + 20).toString() + "px";
            this.hoverDiv.style.top = (y + 20).toString() + "px";
        };
        this.handleMouseMove = (e) => {
            let clientRect = this.overlayCanvas.getBoundingClientRect();
            let scale = this.overlayCanvas.width / clientRect.width;
            let mouseX = (e.clientX - clientRect.left) * scale;
            let mouseY = (e.clientY - clientRect.top) * scale;
            baseloop: for (let b of this.page.blocks) {
                for (let p of b.paragraphs) {
                    for (let l of p.lines) {
                        for (let w of l.words) {
                            if (this.pointInRect(mouseX, mouseY, w.rect)) {
                                this.hoverBox = w;
                                this.hoverDiv.hidden = false;
                                this.moveHoverDiv(e.pageX, e.pageY);
                                break baseloop;
                            }
                        }
                    }
                }
                this.hoverDiv.hidden = true;
            }
        };
        this.pointInRect = (x, y, r) => {
            if (x > r.left && x < r.right && y > r.top && y < r.bottom) {
                return true;
            }
            return false;
        };
        this.confidenceToStyle = (confidence) => {
            if (confidence > 90)
                return "rgba(0,255,20,0.3)"; // green
            else if (confidence > 80)
                return "rgba(130,220,0,0.3)"; // lime
            else if (confidence > 70)
                return "rgba(255,100,0,0.3)"; // orange
            else
                return "rgba(255,0,0,0.3)"; // red
        };
        this.escapeHtml = (unsafe) => {
            return unsafe
                .replace(/&/g, "&amp;")
                .replace(/</g, "&lt;")
                .replace(/>/g, "&gt;")
                .replace(/"/g, "&quot;")
                .replace(/'/g, "&#039;");
        };
        this.docCanvas = document.getElementById("docCanvas");
        this.docCtx = this.docCanvas.getContext("2d");
        this.overlayCanvas = document.getElementById("overlayCanvas");
        this.overlayCtx = this.overlayCanvas.getContext("2d");
        this.docImage = document.getElementById("docImage");
        this.hoverDiv = document.getElementById("hoverDiv");
        this.hoverBox = null;
        this.showWords = true;
        this.drawOverlay(); // actually under the image;
        this.drawDoc();
        this.docCanvas.onmousemove = this.handleMouseMove;
        document.getElementById("blocks").onchange = (e) => {
            this.showBlocks = e.target.checked;
            this.drawOverlay();
        };
        document.getElementById("paragraphs").onchange = (e) => {
            this.showParagraphs = e.target.checked;
            this.drawOverlay();
        };
        document.getElementById("lines").onchange = (e) => {
            this.showLines = e.target.checked;
            this.drawOverlay();
        };
        document.getElementById("words").onchange = (e) => {
            this.showWords = e.target.checked;
            this.drawOverlay();
        };
    }
    drawDoc() {
        this.docCanvas.width = this.docImage.width;
        this.docCanvas.height = this.docImage.height;
        this.docCtx.drawImage(this.docImage, 0, 0);
        let imageData = this.docCtx.getImageData(0, 0, this.docCanvas.width, this.docCanvas.height);
        let data = imageData.data;
        for (let i = 0; i < data.length; i += 4) {
            let lightness = (data[i] + data[i + 1] + data[i + 2]) / 3;
            data[i + 3] = 255 - lightness; // lightness to alpha. Couldn't use .globalCompositeOperation="darken" because this is two overlapping canvases.
        }
        this.docCtx.putImageData(imageData, 0, 0);
    }
}
//# sourceMappingURL=tess.js.map