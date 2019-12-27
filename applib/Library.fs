namespace applib

module Say =
    open System
    let hello (name: string) =
        String.Format("Hello {0}", name)
